using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsNumberButton:clsCalcButton
    {
        public clsNumberButton(int Number)
        {
            // initialize the name and number of the class
            this.Number = Number;
            this.Name = "Number" + this.Number.ToString() + "Button";
        }

        /// <summary>
        /// Process the Number Button.
        /// This button will add the number to the last byte of the current number.
        /// </summary>
        public override int ProcessButton(int CurrentNumber)
        {
            // first let's convert the CurrentNumber into string.
            string sCurrentNumber = CurrentNumber.ToString();

            // then convert number set on the class into string.
            string sNumber = Number.ToString();

            // then combine both of the number, and convert it into interger.
            string sCombineNumber = sCurrentNumber + sNumber;
            int CombineNumber;

            try
            {
                CombineNumber = int.Parse(sCombineNumber);
                return CombineNumber;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + ", when convert String to Number.");
                return -1;
            }
        }
    }
}
