using System;
using System.Collections.Generic;
using System.Text;

namespace DucksV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var donald = new Duck("Sir Donald", "Mallard", 100, 17);
            var daffy = new Duck("Sir Daffy", "Mallard", 99, 14);
            var daisy = new Duck("Miss Daisy", "Marbled Duck", 38, 11);
            var anotherDaisy = new Duck("Sir Daisy", "Mallard", 99, 14);

            Console.WriteLine($"{donald.Name} has the hash code of {donald.GetHashCode()}");
            Console.WriteLine($"{daffy.Name} has the hash code of {daffy.GetHashCode()}");
            Console.WriteLine($"{daisy.Name} has the hash code of {daisy.GetHashCode()}");

            Console.ReadLine();

            Dictionary<Duck, int> ducks = new Dictionary<Duck, int>
            {
                { donald, donald.GetHashCode() },
                { daffy, daffy.GetHashCode() },
                { daisy, daisy.GetHashCode() }
            };


            List<Duck> duckies = new List<Duck>
            {
                donald,
                daffy,
                daisy
            };

            Console.WriteLine("The ducks have now been added to a list and sorted in name");
            foreach (var duck in duckies)
            {
                Console.WriteLine(duck.Name);
            }
            duckies.Sort(new SortDuckHelper());

        
                ToString(duckies);

            Console.ReadLine();
        }
        static void ToString(List<Duck> list)
        {
            StringBuilder result = new StringBuilder("Your ducks in order are: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    result.AppendFormat(" {0}", list[i].Name);
                }
                else
                {
                result.AppendFormat(" {0},", list[i].Name);
                }
            }

            Console.WriteLine(result);
        }
    }
}