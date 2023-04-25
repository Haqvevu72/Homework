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
        public petshop(dog[] Dogs , cat[] Cats) {
            this.Cats = Cats;
            this.Dogs = Dogs;
        }

        // => Remove by nickname
        public void remove() {
            Console.WriteLine("[1] Remove from Cats by nickname");
            Console.WriteLine("[2] Remove from Cats by nickname");
            
        }
    }
}
