// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;
class Program {
    static void Main(string[] args)
    {
        talkingcat Tom = new talkingcat("Tom", 0, "Male", 100, 0, 0);
        Tom.Game();
    }
}
