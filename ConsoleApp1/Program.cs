using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = ("Michael");
            string favMovie = ("Jack and Jill");

            string message = ($"Hello {firstName} I see you like {favMovie}, very interesting choice.");
            Console.WriteLine(message.ToLower());
            Console.WriteLine(favMovie.Contains ("The"));

            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");
            Console.WriteLine("M   M    RRRR ");



            Console.ReadLine();

        }
    }
}
