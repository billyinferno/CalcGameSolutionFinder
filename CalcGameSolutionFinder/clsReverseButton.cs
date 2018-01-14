using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsReverseButton:clsCalcButton
    {
        public clsReverseButton()
        {
            // initialize the name of the class
            this.Name = "ReverseButton";
            this.Number = 0;
        }

        public override int ProcessButton(int CurrentNumber)
        {
            // here we will reverse the number.
            // so the first things that we need to do is convert the number into array of char
            char[] CurrentNumberCharArr = CurrentNumber.ToString().ToCharArray();

            // then reverse the char array
            Array.Reverse(CurrentNumberCharArr);

            // now create new string from the reverse char
            string sNewNumber = new string(CurrentNumberCharArr);

            // then convert the new number and return it
            int NewNumber = 0;
            int.TryParse(sNewNumber, out NewNumber);

            // return the new number
            return NewNumber;
        }
    }
}
