using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsPowButton:clsCalcButton
    {
        public clsPowButton()
        {
            this.Number = 0;
            this.Name = "PowerButton";
        }

        public override int ProcessButton(int CurrentNumber)
        {
            int result = 1;
            // power X the current number
            for(int i = 0; i < this.Number; i++)
            {
                result = result * CurrentNumber;
            }
            return result;
        }
    }
}
