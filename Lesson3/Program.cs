using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Array
                        //Console.WriteLine("{0}   {1}",int.TryParse(Console.ReadLine(),out q), q);
            Console.WriteLine("{0} was entered",ReadValue("Enter the digit "));

            Console.ReadKey(false);
        }
        static int ReadValue (string Caption)
            //Repitiatly reads values and returns last entered int;
        {
            int RetNumber;
            Console.Write(Caption);
            while (!int.TryParse(Console.ReadLine(), out RetNumber))
            {
                Console.WriteLine("Entered value is not Integer, please try again");
                Console.Write(Caption);
            }
            return RetNumber;
        }


    }
}
