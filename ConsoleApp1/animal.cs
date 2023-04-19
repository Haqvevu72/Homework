using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class animal
    {
        // => Our properties
        public string nickname { get; set; }
        public int age { get; set; }    
        public string gender { get; set; }    
        public int energy { get; set; }
        public int price { get; set; }
        public int mealquantity { get; set; }

        // => Our parametrized constructor
        public animal(string nickname, int age, string gender, int energy, int price, int mealquantity){
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.energy = energy;
            this.price = price;
            this.mealquantity = mealquantity;
        }

        // => Eat() function
        public virtual void Eat() {
            if (mealquantity > 0 && energy<100) {
                mealquantity -= 10;
                energy += 10;
            }
        }

        // => Sleep() function
        public virtual void Sleep() {
            if (energy < 100) {
                energy += 10;
            }
        }

        // => Play() function
        public virtual void Play() {
            if (energy > 0) {
                energy -= 10;
            }
        }

        // => ToString() function
        public override string ToString()
        {
            return $"Nick Name: {nickname}\n" +
                   $"Age: {age}\n" +
                   $"Gender: {gender}\n" +
                   $"Energy: {energy}\n" +
                   $"Price: {price}\n" +
                   $"Meal Quantity: {mealquantity}\n";
        }
    }
}
