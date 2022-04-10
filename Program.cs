using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc56_3_MoshCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Write a program and ask the user to enter 5 numbers.
            //    If a number has been previously entered, display an error message 
            //    and ask the user to re-try. Once the user successfully enters 5 unique numbers,
            //    sort them and display the result on the console.

            var number = new int[5];
            Console.WriteLine("Enter 5 unique numbers");

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    var newValue = Convert.ToInt32(Console.ReadLine()); 
                    var currentNumber = Array.IndexOf(number, newValue);
                    if (currentNumber == -1)
                    {
                        number[i] = newValue;
                        break;  
                    }
                    Console.WriteLine("Please, don´t repeat numbers. Try again.");
                }   
            }
            Array.Sort(number);
            Console.WriteLine();

            foreach (var n in number)
                Console.WriteLine(n);  
            Console.WriteLine();
           
        }
    }
}
