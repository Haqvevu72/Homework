﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class dog : animal
    {
        public dog(string nickname, int age, string gender, int energy, int price, int mealquantity) : base(nickname, age, gender, energy, price, mealquantity)
        {
        }

        public override void Eat()
        {
            if (base.energy < 100 && base.mealquantity > 0)
            {
                energy += 10;
                mealquantity -= 10;
            }
            else if (base.energy == 100)
            {
                Console.WriteLine("Energy is full !");
                base.age += 1;
                base.price += 25;
            }
            else
            {
                Console.WriteLine("Meal quantity is not enough !");
            }
        }

        public override void Play()
        {
            if (energy > 0)
            {
                energy -= 10;
            }
            else
            {
                Console.WriteLine("You don't have enough energy to play !");
            }
        }

        public override void Sleep()
        {
            if (energy < 100)
            {
                energy += 10;
            }
            else
            {
                Console.WriteLine("Energy is full !");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
