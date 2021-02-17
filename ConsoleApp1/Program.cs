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
            string firstName = ("Mich@3l");
            string favMovie = ("J@ck @nd Jill");
    
            string e = ("e");

            e = e.Replace("e", "3");

            string message = ($"H{e}llo {firstName} I see you like {favMovie}, very int{e}r{e}sting choic{e}.");
            Console.WriteLine(message.ToLower());
            
            Console.WriteLine(favMovie.Contains ("The"));

            Console.WriteLine("M   M   RRRR ");
            Console.WriteLine("MM MM   R   R");
            Console.WriteLine("MM MM   R   R");
            Console.WriteLine("M M M   RRRR ");
            Console.WriteLine("M   M   R R  ");
            Console.WriteLine("M   M   R  R ");
            Console.WriteLine("M   M   R   R");



            Console.ReadLine();

        }
    }
}
