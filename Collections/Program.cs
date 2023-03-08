using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack            Heap        Değerler 
            //string[] animals = new string[] {"Cat", "Dog", "Bird", "Duck" };
            //Console.WriteLine(animals[0]);
            //Console.WriteLine(animals[1]);
            //Console.WriteLine(animals[3]);


            List<string> animals2 = new List<string> () { "Cat", "Dog", "Bird", "Duck" };
            Console.WriteLine(animals2[0]);
            Console.WriteLine(animals2[1]);
            Console.WriteLine(animals2[2]);
            Console.WriteLine(animals2[3]);
            animals2.Add("Lion");

            Console.WriteLine(animals2[4]);
            Console.WriteLine(animals2[0]);
        }
    }
}
