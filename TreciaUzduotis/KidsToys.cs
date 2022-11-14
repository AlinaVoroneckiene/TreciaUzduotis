using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    abstract class KidsToys : IPlayable
    {
        public string ToyName { get; private set; }
        public int ToyAmount { get; private set; }
        public double Weight { get; private set; }
        public string Kind { get; private set; }

        private int age;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("These toys are not permitted to use for children under 1 year old.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public abstract bool IsExpensive();
        public abstract void PrintToScreen();

        public KidsToys(int age, double weight, string kind, int toyAmount, string toyName)
        {
            ToyAmount = toyAmount;
            ToyName = toyName;
            Age = age;
            Weight = weight;
            Kind = kind;
        }

        //jgvgvj
    }
}
