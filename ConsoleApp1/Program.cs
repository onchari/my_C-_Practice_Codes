using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   /* Write a program that generates a random number
    between 1 and 3 and asks the user to guess what 
    the number is. Tell the user if they guess low, 
    high, or get the correct answer.Also, tell the 
    user if their answer is outside of the range of 
    numbers that are valid guesses(less than 1 or more than 3). 
    You can convert the user's typed answer from a string to an int using this code:
    */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomNumber = new Random();
            int generator = randomNumber.Next(1, 3);

            Console.WriteLine("Guese a number btn 1 and 3 :");
            uint guesenumber = uint.Parse(Console.ReadLine());



            if (guesenumber < 1 || guesenumber > 3)
            {
                Console.WriteLine("Your guese is outside range");
            }

            else if(guesenumber == generator)
            {
                Console.WriteLine($"Correct!!  {guesenumber} is equal to {generator}");
                return;

            }else if(guesenumber < generator)
            {
                Console.WriteLine($"Too Low !! Your guese number {guesenumber} is less than {generator}");
                Console.WriteLine("Guese a number btn 1 and 3 :");
            }
            else
            {
                Console.WriteLine($"Too High!! Your guese number {guesenumber} is higher than {generator}");
                Console.WriteLine("Guese a number btn 1 and 3 :");
            }

            Console.ReadLine();

        }
    }
}
