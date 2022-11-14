using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    class BoyToys : KidsToys
    {
        public double Price { get; private set; }

        public BoyToys(int age, double weight, string kind, 
            int toyAmount, string toyName, double price) 
            : base(age, weight, kind, toyAmount, toyName)
        {
            Price = price;
        }

        public override bool IsExpensive()
        {
            if(Price<=15.00)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void PrintToScreen()
        {
            Console.WriteLine($"For {Price} $ the shop can offer your son a {Kind} named \"{ToyName}\". \n{ToyName} is permitted to use in children who are {Age} years old and weigh {Weight} kg. There are {ToyAmount} {ToyName} left in the store. ");
        }
    }
}
