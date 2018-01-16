using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsMinusButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of the Minus Button Class
        /// </summary>
        /// <param name="Number"></param>
        public clsMinusButton(int Number)
        {
            // initialize the number and the name of the button
            this.Number = Number;
            this.Name = "Minus" + this.Number.ToString() + "Button";
        }

        public override int ProcessButton(int CurrentNumber)
        {
            // here we will perform minus on the Current Number with the Number of the Button
            return (CurrentNumber - this.Number);
        }
    }
}
