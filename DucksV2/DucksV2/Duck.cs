using System;

namespace DucksV2
{

    public class Duck : IEquatable<Duck>
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override int GetHashCode()
        {
            int hash = Name.GetHashCode();
            hash = (hash * 23) + Type.GetHashCode();
            hash = (hash * 23) + WeightInGrams;
            hash = (hash * 23) + AgeInMonths;

            return hash;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj);
        }

        public bool Equals(Duck obj)
        {
            return obj != null && obj.GetHashCode() == obj.GetHashCode();
        }
    }
}