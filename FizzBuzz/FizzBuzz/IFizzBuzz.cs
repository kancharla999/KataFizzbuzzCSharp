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
        string Answer(int number);
    }
}
