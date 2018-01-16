using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsPlusMinusButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of PlusMinusButton class
        /// </summary>
        public clsPlusMinusButton()
        {
            // initialize the public variable
            this.Number = -1;
            this.Name = "PlusMinusButton";
        }

        /// <summary>
        /// This button will change the value from Minus to Plus, and Plus to Minus.
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <returns></returns>
        public override int ProcessButton(int CurrentNumber)
        {
            // just multiple current number with -1.
            return (CurrentNumber * (-1));
        }
    }
}
