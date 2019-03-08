using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsChallenge
{
    class Dog
    {
        public Dog(string name, string owner, double weight)
        {
            Name = name;
            Owner = owner;
            Weight = weight;
        }

        public string pType { get; }
        public string Name { get; }
        public string Owner { get; }
        public double Weight { get; }

        public string getTag()
        {
            string tag = "If lost, call " + Owner;
            return tag;
        }

        public string bark(int count)
        {
            int i = 1;
            string barks = "Bark!";
            string nOfBarks = "";
            while (i <= count)
            {
                nOfBarks = nOfBarks + barks;
                i++;
            }
            return nOfBarks;
        }
    }
}
