using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArrLength;
            int ArrMin = 0;
            int ArrMax = 0;
            ArrLength = ReadValue("Enter the table lenth > ");
            int[] InputArray;
            InputArray = new int[ArrLength];
            for (int index = 0; index < ArrLength; index++)
            {//Enter arrays' values
                InputArray[index] = ReadValue("Enter array value > ");
                if (index == 0)
                {   //Initialization of min-max selection
                    //Before computation of min and max values set both equail to first array element.
                    ArrMin = InputArray[0];
                    ArrMax = InputArray[0];
                }
                else
                    {// Other cycles are applicable for checking min and max values
                    if (ArrMin > InputArray[index])
                    { ArrMin = InputArray[index]; }
                    if (ArrMax < InputArray[index])
                    { ArrMax = InputArray[index]; }
                }
            }
            // Display the results
            Console.WriteLine("Array length = {0}, Min = {1}, Max = {2}", ArrLength, ArrMin, ArrMax);
            Console.WriteLine("Press any key to exit.");
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
