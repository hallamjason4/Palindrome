using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to see if it is a palindrome: ");
            string checkPal = (Console.ReadLine());

            if (checkPal.SequenceEqual(checkPal.Reverse()) == true){
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

            Console.ReadLine();
        }
    }
}
