using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        public static (int, int) GetYearAnimals(int years)
        {
            int catYears = 15;

            int dogYears = 15;

            for (int humanYears = 2; humanYears <= years; humanYears++)
            {
                if (humanYears == 2)
                {
                    catYears += 9;

                    dogYears += 9;
                }
                else
                {
                    catYears += 4;

                    dogYears += 5;
                }
            }

            return (catYears, dogYears);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input: how many years ago you adopted the animals ");

            int years = int.Parse(Console.ReadLine());

            (int, int) animalYears = GetYearAnimals(years);

            Console.WriteLine($"{animalYears.Item1} {animalYears.Item2} ");

            Console.ReadLine();
        }
    }
}

