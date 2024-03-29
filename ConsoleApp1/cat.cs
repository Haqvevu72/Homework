﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class cat : animal
    {
        public cat(string nickname, int age, string gender, int energy, int price, int mealquantity) : base(nickname, age, gender, energy, price, mealquantity)
        {
        }

        public override void Eat()
        {
            if (base.energy < 100 && base.mealquantity > 0)
            {
                base.energy = 100;
                base.mealquantity = 0;
                base.price += 20;
                base.age += 1;
            }
            else if (base.energy == 100 && mealquantity!=0)
            {
                Console.Clear();
                Console.WriteLine("Energy is full !");
                Thread.Sleep(1200);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Meal quantity is not enough !");
                Thread.Sleep(1200);
            }
            
        }

        public override void Play()
        {
            if (base.energy > 0)
                base.energy = 0;
            else
            {
                Console.Clear();
                Console.WriteLine("You don't have enough energy to play !");
                Thread.Sleep(1200);
            }
        }

        public override void Sleep(){
            if (base.energy != 100)
            {
                base.energy = 100;
                base.age += 1;
                base.price += 20;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Energy is full !");
                Thread.Sleep(1200);
            }
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
