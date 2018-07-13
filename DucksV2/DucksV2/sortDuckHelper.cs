using System;
using System.Collections.Generic;

namespace DucksV2
{
    class SortDuckHelper : IComparer<object>
    {
        int IComparer<object>.Compare(object x, object y)
        {
            if (x is Duck && y is Duck)
            {
                Duck duckOne = (Duck)x;
                Duck duckTwo = (Duck)y;
                Console.WriteLine($"{duckOne.Name} is being compared to {duckTwo.Name}");

                if (String.CompareOrdinal(duckOne.Name, duckTwo.Name) == 0)
                {
                    Console.WriteLine($"{duckOne.Name} and {duckTwo.Name} are the same so we are ordering them now by weight");

                    if (duckOne.WeightInGrams > duckTwo.WeightInGrams)
                    {
                        Console.WriteLine($"{duckOne.Name} is above in weight by {duckOne.WeightInGrams} to {duckTwo.Name}'s {duckTwo.WeightInGrams}");
                        return 1;
                    }

                    else
                    {
                        Console.WriteLine($"{duckTwo.Name} is above in weight by {duckTwo.WeightInGrams} to {duckOne.Name}'s {duckOne.WeightInGrams}");
                        return -1;
                    }
                }
                else
                {
                    if (String.Compare(duckOne.Name, duckTwo.Name, true) == 1)
                    {
                        Console.WriteLine($"{duckOne.Name} is higher in the alphabet compared to {duckTwo.Name}");

                    }
                    if (String.Compare(duckOne.Name, duckTwo.Name, true) == -1)
                    {
                        Console.WriteLine($"{duckTwo.Name} is higher in the alphabet compared to {duckOne.Name}");

                    }
                    return String.Compare(duckOne.Name, duckTwo.Name, true);
                }
            }
            else
            {
                throw new Exception("One or more objects are not object Duck");
            }
        }
    }
}
