using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Author: Aslan Mirsakiyev
* Date: May 17, 2016
* Date MOdified : May 17, 2016
* Description : Advanced Methods Demo for Lesson 2
* Version 0.0.5 - added readUntilEnd - not completed
*/


namespace COMP123_S2016_Lesson2
{
    /**
    * Main driver class for Lesson 2
    *
    * @class Program
    */
    public class Program
    {
        /**
        * Main method for our driver class
        *
        * @constructor
        * @param {string[]} args
        */
         static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;
            int numberOfEntries;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x,ref y);

            Console.WriteLine(x);

            Console.WriteLine();

           

           
                Console.WriteLine("How many entries do you want to make?");
                int.TryParse(Console.ReadLine(), out numberOfEntries);
                if(numberOfEntries>0)
                {
                    readUntilEnd(numberOfEntries);
                }

                readUntilEnd(numberOfEntries);
            
            
           
        }

        /**
         * Simple method to add two values
         *
         * @method addXandY
         * @param {int} firstNumber
         * @param {int} secondNumber
         */
        public static int addXandY(int firstNumber, int secondNumber)
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }

        /**
         * Simple method to demonstrate pass by reference with ref keyword
         * 
         * @method addYtoX
         * @param {ref int} X
         * @param {ref int} Y
         */
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;

            return X;
        }

        public static int readUntilEnd(int numberOfEntries)
        {
            
            string[] inputs = new string[numberOfEntries];
            int inputCounter = 0;
            
          
            do
            {
                Console.WriteLine("Enter a value - ('end' to stop)");
                inputs[inputCounter] = "";
                inputs[inputCounter] = Console.ReadLine();
                inputCounter++;
                

            } while ((inputs[inputCounter-1]!="end")&&(inputCounter<numberOfEntries));

            return inputCounter;
        }
    }
}
