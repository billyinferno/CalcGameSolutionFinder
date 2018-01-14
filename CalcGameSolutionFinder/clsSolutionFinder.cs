using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsSolutionFinder
    {
        private string[] ButtonData;
        private int CurrentNumber;
        private int TargetNumber;
        private int MaximumMoves;
        public List<string> Solution { get; private set; }

        // Button Action class
        private clsNumberButton btnNumber = new clsNumberButton(0);
        private clsAddButton btnAdd = new clsAddButton(0);
        private clsMinusButton btnMinus = new clsMinusButton(0);
        private clsDivideButton btnDivide = new clsDivideButton(0);
        private clsMultiplyButton btnMultiply = new clsMultiplyButton(0);
        private clsPlusMinusButton btnPlusMinus = new clsPlusMinusButton();
        private clsShiftButton btnShift = new clsShiftButton();
        private clsReverseButton btnReverse = new clsReverseButton();

        public clsSolutionFinder(string ButtonData, int CurrentNumber, int TargetNumber, int MaximumMoves)
        {
            // first parse the ButtonData and ensure we got 5 data, otherwise we can throw an exception
            this.ButtonData = ButtonData.Split(new string[] { "," }, StringSplitOptions.None);
            if (!(this.ButtonData.Length == 5))
            {
                throw new Exception("Button Data given: " + ButtonData + ", is wrong. Cannot perform Solution Finder.");
            }

            // if okay then move all the Current Number, Target Number, and Maximum Moves to the private variable
            this.CurrentNumber = CurrentNumber;
            this.TargetNumber = TargetNumber;
            this.MaximumMoves = MaximumMoves;

            // initialize other variable
            this.Solution = new List<string>();
        }

        public bool FindSolution()
        {
            // we can find the solution by using DFS.
            // for this we need to clear our previous result, and prepare the variable of the current result
            this.Solution.Clear();
            List<string> result = new List<string>();

            // call the BuildSolutionTree
            if (BuildSolutionTree(result, "", 0, this.CurrentNumber))
            {
                // success, we got the data
                return true;
            }

            // if we reach this, it means that the solution is not being found
            return false;
        }

        private bool BuildSolutionTree(List<string> result, string pButtonData, int CurrentMove, int CurrentNumber)
        {
            string ButtonType;
            string pButtonType;
            string sButtonNumber;
            int ButtonNumber = 0;
            int tmpCurrentNumber = 0;
            int tmpCurrentMove = CurrentMove;
            bool skipData;

            // add new moves every time we call this location
            tmpCurrentMove += 1;

            // check if we already run out of moves
            if (tmpCurrentMove > this.MaximumMoves)
            {
                return false;
            }
            else
            {
                // we not run out of moves, now we can try what move we can process, by looping thru the ButtonData
                for (int i = 0; i < this.ButtonData.Length; i++)
                {
                    skipData = false;

                    // ensure that button type is not empty
                    if (this.ButtonData[i].Trim().Length > 0)
                    {
                        // for the solution, there are 2 condition that need to be meet
                        // before we process each button data
                        // (1) if previous button data is "N", we cannot perform any "<<"
                        // (2) if previous button data is "PM", we cannot perform any "PM"
                        // because it will nulify the previous solution build.

                        // check the button type
                        ButtonType = this.ButtonData[i].Substring(0, 1);
                        pButtonType = "";
                        if (pButtonData.Trim().Length > 0)
                        {
                            pButtonType = pButtonData.Substring(0, 1);
                        }
                        if (pButtonType == "N" && ButtonType == "<")
                        {
                            // skip the data
                        }
                        else if (pButtonType == "P" && ButtonType == "P")
                        {
                            // skip the data
                        }
                        else
                        {
                            // process the button type, that need parsed the number data.
                            switch (ButtonType)
                            {
                                case "+":
                                case "-":
                                case "/":
                                case "\\":
                                case "*":
                                case "#":
                                case "N":
                                    // get the number and parse it into integer
                                    sButtonNumber = this.ButtonData[i].Substring(1, this.ButtonData[i].Length - 1);
                                    int.TryParse(sButtonNumber, out ButtonNumber);
                                    break;
                            }

                            // now process for each button action
                            switch (ButtonType)
                            {
                                case "+":
                                    this.btnAdd.Number = ButtonNumber;
                                    tmpCurrentNumber = this.btnAdd.ProcessButton(CurrentNumber);
                                    break;
                                case "-":
                                    this.btnMinus.Number = ButtonNumber;
                                    tmpCurrentNumber = this.btnMinus.ProcessButton(CurrentNumber);
                                    break;
                                case "/":
                                case "\\":
                                    // check if we can perform divide on the data or not?
                                    if (CurrentNumber > ButtonNumber)
                                    {
                                        if (CurrentNumber % ButtonNumber == 0)
                                        {
                                            if (ButtonType == "\\")
                                            {
                                                ButtonNumber *= -1;
                                            }
                                            this.btnDivide.Number = ButtonNumber;
                                            tmpCurrentNumber = this.btnDivide.ProcessButton(CurrentNumber);
                                        }
                                        else
                                        {
                                            skipData = true;
                                        }
                                    }
                                    else
                                    {
                                        skipData = true;
                                    }
                                    break;
                                case "*":
                                case "#":
                                    if (ButtonType == "#")
                                    {
                                        ButtonNumber *= -1;
                                    }
                                    this.btnMultiply.Number = ButtonNumber;
                                    tmpCurrentNumber = this.btnMultiply.ProcessButton(CurrentNumber);
                                    break;
                                case "N":
                                    this.btnNumber.Number = ButtonNumber;
                                    tmpCurrentNumber = this.btnNumber.ProcessButton(CurrentNumber);
                                    break;
                                case "<":
                                    tmpCurrentNumber = this.btnShift.ProcessButton(CurrentNumber);
                                    break;
                                case "P":
                                    tmpCurrentNumber = this.btnPlusMinus.ProcessButton(CurrentNumber);
                                    break;
                                case "R":
                                    tmpCurrentNumber = this.btnReverse.ProcessButton(CurrentNumber);
                                    break;
                            }

                            // ensure that we don't need to skip data here?
                            // if we need to skip, just go directly to next button.
                            if (!skipData)
                            {
                                // check whether this current number is within the boundary or the game solution or not?
                                // if not then we can just move to the next button data
                                if (tmpCurrentNumber >= -9999 && tmpCurrentNumber <= 9999)
                                {

                                    List<string> tmpResult = new List<string>();
                                    // if we already have previous result, copy the result to our list first
                                    if (result.Count > 0)
                                    {
                                        tmpResult = result.ToList();
                                    }
                                    tmpResult.Add(this.ButtonData[i]);
                                    Console.WriteLine(string.Join(",", tmpResult.ToArray()));
                                    // once we got the data, check whether we already reached the target number
                                    // or not?
                                    if (tmpCurrentNumber == this.TargetNumber)
                                    {
                                        // copy the result to the solution
                                        this.Solution = tmpResult.ToList();
                                        return true;
                                    }
                                    else
                                    {
                                        // not reaching the target number, try to branch another tree
                                        if (BuildSolutionTree(tmpResult, this.ButtonData[i], tmpCurrentMove, tmpCurrentNumber))
                                        {
                                            // if found in another branch the no need to continue to all the tree
                                            return true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // we run out of ButtonData, this is not the solution
                return false;
            }
        }
    }
}
