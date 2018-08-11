using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nihil83
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcome = "Welcome To Nihil83 Where we put time into useless projects!";
            string menu = "Select Mode: \n 1. Hacker \n 2. Spam \n 3. Exit";
            string option = "";

            while (option != "3")
            {
                Console.WriteLine(welcome);
                Console.WriteLine(menu);
                option = Console.ReadLine();
                if (option == "1")
                {
                    HackerMode();
                }
                if (option == "2")
                {
                    SpamMode();
                }
            }
        }

        static private void HackerMode()
        {
            Console.WriteLine("You are in Hackermode.");
            Console.ReadLine();
        }
        static private void SpamMode()
        {
            Console.WriteLine("You made it! Into spam mode");
            Console.ReadLine();
        }
            
    }
}
