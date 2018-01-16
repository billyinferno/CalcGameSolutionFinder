using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsReplaceButton:clsCalcButton
    {
        public clsReplaceButton()
        {
            // initialize the name and the number for the Replace Button
            this.Name = "ButtonReplace";
        }

        public override int ProcessButton(int CurrentNumber)
        {
            // for replacing the characted on the Button, we can use native replace function
            // on the string class
            int result = 0;
            int.TryParse(CurrentNumber.ToString().Replace(this.Number.ToString(), this.NumberReplace.ToString()), out result);

            // return result to caller
            return result;
        }
    }
}
