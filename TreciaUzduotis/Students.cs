using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    class Students : IOld
    {
        private string name;

        public int age;
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 18)
                {
                    throw new Exception("You are too young to attend a military college.");
                }
                else
                {
                    age = value;
                }
            }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            private set
            {
                if(value < 60.00)
                {
                    throw new Exception("Your weight is too small for a military college.");
                }
                else
                {
                    weight = value;
                }
            }
        }

        public Students (string name, int age, double weight)
        {
            this.name = name;
            Age = age;
            Weight = weight;
        }

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Welcome, {name}! You are enrolled to the military college! \nYour personal qualifications meet the specified requirements: \nAge: {Age} y/o  \nWeight: {Weight} kg");
        }


    }
}
