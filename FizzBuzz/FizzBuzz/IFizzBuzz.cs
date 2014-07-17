using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    interface IFizzBuzz
    {    
        /// <summary>
        /// Give an answer to the current game
        /// </summary>
        /// <param name="number">current number in the game sequence</param>
        /// <returns>appropriate answer to the current number</returns>
        // If the number is divisable by 3 print "Fizz"
        // If the number is divisable by 5 print "Buzz"
        // If the number is divisable by 3 and 5 print "FizzBuzz"
        // Otherwise print the number
        string Answer(int number);
    }
}
