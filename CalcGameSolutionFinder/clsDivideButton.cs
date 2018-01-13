using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsDivideButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of the Divide Button Class
        /// </summary>
        /// <param name="Number"></param>
        public clsDivideButton(int Number)
        {
            // initialize the number and name of the button
            this.Number = Number;
            this.Name = "Divide" + this.Number.ToString() + "Button";
        }

        /// <summary>
        /// Divide current number with the number of the class.
        /// The result will always going to be in the Integer format.
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <returns></returns>
        public override int ProcessButton(int CurrentNumber)
        {
            // divide current number with the number
            return (CurrentNumber / this.Number);
        }
    }
}
