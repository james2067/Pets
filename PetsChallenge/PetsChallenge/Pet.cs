using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsChallenge
{
    class Pet
    {
        public Pet(string type, string name, string owner, double weight)
        {
            pType = type;
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
    }
}
