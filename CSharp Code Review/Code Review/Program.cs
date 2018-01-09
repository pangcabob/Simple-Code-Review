using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the Salutatuion class for a Walmart Greeter.
            Salutation oldGuy = new Salutation("Welcome to Walmart!", "Thanks for shopping at Walmart!");
            //Get the guys to talk
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.SayFarewell());
        }
    }
}
