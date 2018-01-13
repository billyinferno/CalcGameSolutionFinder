using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsAddButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of the Add Button Class.
        /// </summary>
        /// <param name="Number"></param>
        public clsAddButton(int Number)
        {
            // assign the number of this class and auto generate the name of the Button
            this.Number = Number;

            // init the name of this class
            this.Name = "Add" + this.Number.ToString() + "Button";
        }

        /// <summary>
        /// This function will add the Current Number with the Number set on the Button.
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <returns></returns>
        public override int ProcessButton(int CurrentNumber)
        {
            return (CurrentNumber + this.Number);
        }
    }
}
