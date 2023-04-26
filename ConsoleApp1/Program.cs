// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main(string[] args)
    {
        cat c1 = new cat("Mike", 12, "Male", 100, 120, 0);
        cat c2 = new cat("Tyson", 11, "Male", 100, 140, 0);
        cat c3 = new cat("Jane", 2, "Female", 100, 120, 0);

        cat[] cats = new cat[3] { c1, c2, c3 };

        dog d1 = new dog("Mike", 12, "Male", 100, 120, 0);
        dog d2 = new dog("Tyson", 11, "Male", 100, 140, 0);
        dog d3 = new dog("Jane", 2, "Female", 100, 120, 0);

        dog[] dogs = new dog[3] { d1, d2, d3 };
        petshop petshop = new petshop(dogs, cats);
        petshop.remove();
        Console.WriteLine(petshop.ToString());
    }
}
