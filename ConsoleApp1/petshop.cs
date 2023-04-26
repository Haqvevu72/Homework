using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class petshop
    {
        // => Properties of our class
        public cat[] Cats { get; set; }
        public dog[] Dogs { get; set; }

        // => Parametrized Constructor of our class
        public petshop(dog[] Dogs, cat[] Cats)
        {
            this.Cats = Cats;
            this.Dogs = Dogs;
        }

        // => Remove by nickname
        public void remove()
        {
            ConsoleKeyInfo key;
            string nickname;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Remove from Cats by nickname");
                Console.WriteLine("[2] Remove from Dogs by nickname");
                Console.Write("Choice here...");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.NumPad1)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.NumPad2)
                {
                    break;
                }
            }
            Console.Clear();
            Console.Write("Enter nickname...");
            bool exist = false;
            nickname = Console.ReadLine();
            if (key.Key == ConsoleKey.NumPad1)
            {
                foreach(cat c in Cats) {
                    if (nickname == c.nickname) {
                        exist = true;
                    }
                }
                if (exist)
                {
                    cat[] NewCats = new cat[Cats.Length - 1];
                    int counter = 0;
                    for (int i = 0; i < Cats.Length; i++)
                    {
                        if (Cats[i].nickname != nickname)
                        {
                            NewCats[counter] = Cats[i];
                            counter++;
                        }
                    }
                    Cats = NewCats;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("This cat does not exist !");
                }
            }
            else if (key.Key == ConsoleKey.NumPad2)
            {
                foreach (dog d in Dogs)
                {
                    if (nickname == d.nickname)
                    {
                        exist = true;
                    }
                }
                if (exist)
                {
                    dog[] NewDogs = new dog[Dogs.Length - 1];
                    int counter = 0;
                    for (int i = 0; i < Dogs.Length; i++)
                    {
                        if (Dogs[i].nickname != nickname)
                        {
                            NewDogs[counter] = Dogs[i];
                            counter++;
                        }
                    }
                    Dogs = NewDogs;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This dog does not exist !");
                }
            }
        }

        // => See result
        public override string ToString() {
            string? result = null;
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("[1] -> Show Cats");
                Console.WriteLine("[2] -> Show Dogs");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.NumPad1)
                {
                    foreach (cat c in Cats)
                    {
                        result += c.ToString() + "\n";
                    }
                    break;
                }
                else if (key.Key == ConsoleKey.NumPad2)
                {
                    foreach (dog d in Dogs)
                    {
                        result += d.ToString() + "\n";
                    }
                    break;
                }
            }
            return result ?? "+";
        }
    }
}
