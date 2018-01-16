using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsMultiplyButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of Multiply Button Class
        /// </summary>
        /// <param name="Number"></param>
        public clsMultiplyButton(int Number)
        {
            // initialize the number and the name of the button
            this.Number = Number;
            this.Name = "Multiply" + this.Number + "Button";
        }

        /// <summary>
        /// Perform the multiply to the current number.
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <returns></returns>
        public override int ProcessButton(int CurrentNumber)
        {
            // multiply the current number with the number set during initialization
            return (CurrentNumber * this.Number);
        }
    }
}
