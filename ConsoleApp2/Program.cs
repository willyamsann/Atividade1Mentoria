using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("Menu de opçõs Mentoria");
                Console.WriteLine("Escolha sua opção");
                Console.WriteLine("1 - Atividade 1");
                Console.WriteLine("2 - Atividade 2");
                Console.WriteLine("3 - Atividade 3");
                Console.WriteLine("Tecle qualquer numero diferente das opção acima para sair");
                var option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Opção 1");
                        List<int> idades = new List<int>();
                        var count = 5;
                        for (var i = 0; i < count; i++)
                        {
                            Console.WriteLine("Digite a Idade da Pessoa Nª" + i + 1);

                            var idade = Int32.Parse(Console.ReadLine());

                            idades.Add(idade);
                        }

                        var calculateOne = CalculateAtvd1(idades);
                        Console.WriteLine("Media: " + calculateOne.Media);
                        Console.WriteLine("Idade Maior: " + calculateOne.IdadeMaior);
                        Console.WriteLine("Idade Menor: " + calculateOne.IdadeMenor);
                        break;

                    case 2:
                        Console.WriteLine("Opção 2");
                        break;

                    case 3:
                        Console.WriteLine("Opção 3");
                        break;

                    default:
                        loopContinue = false;
                        Console.WriteLine("Default");
                        break;
                }

            }




        }

        public static Atvd1 CalculateAtvd1(List<int> idades)
        {
            var atividadeResult = new Atvd1();
            atividadeResult.IdadeMaior = 0;
            atividadeResult.IdadeMenor = 0;
            atividadeResult.Idades = idades;
            var somaIdades = 0;
            foreach (var idade in idades)
            {
                somaIdades = somaIdades + idade;
            }
            atividadeResult.Media = somaIdades / 5;



            foreach (var idade in idades)
            {
                if (idade >= atividadeResult.IdadeMaior)
                {
                    atividadeResult.IdadeMaior = idade;
                }

                if (atividadeResult.IdadeMenor == 0)
                {
                    atividadeResult.IdadeMenor = idade;
                }


                if (idade <= atividadeResult.IdadeMenor)
                {
                    atividadeResult.IdadeMenor = idade;
                }
            }

            return atividadeResult;
        }

      
    }
}
