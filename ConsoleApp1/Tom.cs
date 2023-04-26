using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class talkingcat : cat
    {
        private int coin = 0;
        public talkingcat(string nickname, int age, string gender, int energy, int price, int mealquantity) : base(nickname, age, gender, energy, price, mealquantity)
        {

        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Play()
        {
            base.Play();
            coin += 45;
        }

        public override void Sleep()
        {
            base.Sleep();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        // => Function for buy meal
        private void BuyMeal()
        {

            // => Getting choice
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" [1] 25% full depo - 10 coin ");
                Console.WriteLine(" [2] 50% full depo - 15 coin ");
                Console.WriteLine(" [3] 100% full depo - 20 coin ");
                Console.Write("Choice Here: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.NumPad1)
                {
                    if (coin >= 10)
                    {
                        coin -= 10;
                        mealquantity = 25;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough coin");
                    }
                    break;
                }
                else if (key.Key == ConsoleKey.NumPad2)
                {
                    if (coin >= 15)
                    {
                        coin -= 15;
                        mealquantity = 50;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough coin");
                    }
                    break;
                }
                else if (key.Key == ConsoleKey.NumPad3)
                {
                    if (coin >= 20)
                    {
                        coin -= 20;
                        mealquantity = 100;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You don't have enough coin");
                    }
                    break;
                }
            }

        }

        // => Function for play
        public void Game()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(ToString());
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n[1] -> Play Game");
                    Console.WriteLine("[2] -> Eat Food");
                    Console.WriteLine("[3] -> Sleep");
                    Console.WriteLine("[4] -> Buy Food");
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.NumPad1:
                            Play();
                            flag = false;
                            break;
                        case ConsoleKey.NumPad2:
                            Eat();
                            flag = false;
                            break;
                        case ConsoleKey.NumPad3:
                            Sleep();
                            flag = false;
                            break;
                        case ConsoleKey.NumPad4:
                            BuyMeal();
                            flag = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(ToString());
                            break;
                    }
                }
            }

        }
    }
}
