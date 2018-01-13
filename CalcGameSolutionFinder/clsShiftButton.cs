using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsShiftButton:clsCalcButton
    {
        /// <summary>
        /// Constructor of Shift Button Class
        /// </summary>
        public clsShiftButton()
        {
            // initialize all the data for the Shift Button
            this.Name = "ShiftButton";
            this.Number = -1;
        }

        /// <summary>
        /// Remove the left most of the number (shift left).
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <returns></returns>
        public override int ProcessButton(int CurrentNumber)
        {
            // Shift Left the number, for this we can first convert current number into string.
            string sCurrentNumber = CurrentNumber.ToString();

            // then just cut the left part of the current number
            sCurrentNumber = sCurrentNumber.Substring(0, (sCurrentNumber.Length - 1));

            // then convert it back to number
            int ShiftNumber;
            int.TryParse(sCurrentNumber, out ShiftNumber);

            // return the current number value
            return ShiftNumber;
        }
    }
}
