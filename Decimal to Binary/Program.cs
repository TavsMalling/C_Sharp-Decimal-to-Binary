using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)

        {
            //I use a bool here to set a true or false condition.
            bool terminate = false;
            do
            {
                //This a program made to convert any whole decimal number above 0 and below 32768 into a binary number.
                Console.Clear();

                double binaryStart = 2;
                double binaryUplift = 15;

                Console.Write("Input whole number from the decimal system -> ");
                string sInputNumber = Console.ReadLine();
                double dInputNumber = Convert.ToDouble(sInputNumber);
               //I use doubles here since I need to use a math.pow which can only be used with doubles.
               
                while (binaryUplift != -1)
                {
                    double binaryDivide = Math.Pow(binaryStart, binaryUplift);
                    
                    if (dInputNumber - binaryDivide >= 0)
                    {
                        //If input is bigger than 2^(binaryDivide) then the result is bigger than 1 
                        Console.Write(" 1");
                        dInputNumber = dInputNumber - binaryDivide;
                        binaryUplift--;
                    }
                    else
                    {
                        Console.Write(" 0");
                        dInputNumber = dInputNumber - 0;
                        binaryUplift--;
                    }
                }

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Do you want to continue? y/n");
                if (Console.ReadLine() == "y")
                {
                    terminate = false ;
                }
                else
                {
                    terminate = true;
                }
                              
            } while (terminate == false);
            
        }
    }
}
