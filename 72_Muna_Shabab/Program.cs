using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//Chapter 7 Exercise 72
//written by:Muna Shabab
//date:10-8-2020

namespace _72_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number ;
            int reversedNum ;

            //explain the purpose of the program
            Console.WriteLine("This Program takes in a positive integer and reverse it");

            //prompt the user for input and validate
            Console.WriteLine("Enter a positive integer greater or equal to 1:");
            input = Console.ReadLine();
            number = GetValidInteger(input);
            
            //reverse the number
            reversedNum=ReverseInt(number);

            //display the reversed number
            Console.WriteLine("the resersed  number is "+(reversedNum));

            Console.ReadLine();

        }

        public static int GetValidInteger(string input)
        {
            int num;
            while ((!(int.TryParse(input, out num))) || num <1)
            {

                Console.WriteLine(input + " is not a valid  input");
                Console.WriteLine("please enter a positive integer greater or equal to  1:");
                input = Console.ReadLine();
            }

            return num;
        }

        public static int ReverseInt(int intToReverse)
        {
            int num =0;
            while ( intToReverse >0)
            {
                num = (10 * num) + (intToReverse % 10);
                intToReverse /= 10;
            }

            return num;
        }
    }
}
