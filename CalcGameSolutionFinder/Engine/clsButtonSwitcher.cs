using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsButtonSwitcher
    {
        private clsAddButton btnAdd;
        private clsDivideButton btnDivide;
        private clsMinusButton btnMinus;
        private clsMultiplyButton btnMultiply;
        private clsNumberButton btnNumber;
        private clsPlusMinusButton btnPlusMinus;
        private clsReplaceButton btnReplace;
        private clsReverseButton btnReverse;
        private clsShiftButton btnShift;
        private clsPowButton btnPow;

        /// <summary>
        /// Constructor of Button Switcher class
        /// </summary>
        public clsButtonSwitcher()
        {
            // initialize all the class
            this.btnAdd = new clsAddButton(0);
            this.btnDivide = new clsDivideButton(0);
            this.btnMinus = new clsMinusButton(0);
            this.btnMultiply = new clsMultiplyButton(0);
            this.btnNumber = new clsNumberButton(0);
            this.btnPlusMinus = new clsPlusMinusButton();
            this.btnReplace = new clsReplaceButton();
            this.btnReverse = new clsReverseButton();
            this.btnShift = new clsShiftButton();
            this.btnPow = new clsPowButton();
        }

        /// <summary>
        /// Load the button data and process it using the correct Calc Class.
        /// By integrating the Load Button Data procedure, we just need to maintain
        /// single point to change the functionality of the button.
        /// </summary>
        /// <param name="ButtonData">Button data that will be loaded</param>
        /// <param name="CurrentNumber">Current number</param>
        /// <returns></returns>
        public int LoadButton(string ButtonData, int CurrentNumber)
        {
            int Number;
            int NumberReplace;
            string[] NumberData = new string[2];

            switch (ButtonData.Substring(0, 1))
            {
                case "+":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    this.btnAdd.Number = Number;
                    CurrentNumber = this.btnAdd.ProcessButton(CurrentNumber);
                    break;
                case "-":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    this.btnMinus.Number = Number;
                    CurrentNumber = this.btnMinus.ProcessButton(CurrentNumber);
                    break;
                case "*":
                case "#":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    if (ButtonData.Substring(0, 1) == "#")
                    {
                        Number *= -1;
                    }
                    this.btnMultiply.Number = Number;
                    CurrentNumber = this.btnMultiply.ProcessButton(CurrentNumber);
                    break;
                case "/":
                case "\\":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    if (ButtonData.Substring(0, 1) == "\\")
                    {
                        Number *= -1;
                    }
                    this.btnDivide.Number = Number;
                    CurrentNumber = this.btnDivide.ProcessButton(CurrentNumber);
                    break;
                case "P":
                    CurrentNumber = this.btnPlusMinus.ProcessButton(CurrentNumber);
                    break;
                case "<":
                    CurrentNumber = this.btnShift.ProcessButton(CurrentNumber);
                    break;
                case "R":
                    CurrentNumber = this.btnReverse.ProcessButton(CurrentNumber);
                    break;
                case "N":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    this.btnNumber.Number = Number;
                    CurrentNumber = this.btnNumber.ProcessButton(CurrentNumber);
                    break;
                case "S":
                    NumberData = ButtonData.Substring(1, ButtonData.Length - 1).Split(new string[] { "|" }, StringSplitOptions.None);
                    int.TryParse(NumberData[0], out Number);
                    int.TryParse(NumberData[1], out NumberReplace);
                    this.btnReplace.Number = Number;
                    this.btnReplace.NumberReplace = NumberReplace;
                    CurrentNumber = this.btnReplace.ProcessButton(CurrentNumber);
                    break;
                case "^":
                    int.TryParse(ButtonData.Substring(1, ButtonData.Length - 1), out Number);
                    this.btnPow.Number = Number;
                    CurrentNumber = this.btnPow.ProcessButton(CurrentNumber);
                    break;
                default:
                    throw new Exception("Unknown Button Tag");
            }

            // return current number to the caller
            return CurrentNumber;
        }
    }
}
