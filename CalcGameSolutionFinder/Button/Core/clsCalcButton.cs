using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    public class clsCalcButton
    {
        /// <summary>
        /// Name is the name of the Child Class that will be inheritance the CalcButton Base Clas
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Number Value of the Button.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Number that will be used to Replace on the Button
        /// </summary>
        public int NumberReplace { get; set; }

        public clsCalcButton() {
            // initialize all the public variable that will be used
            this.Name = "";
            this.Number = 0;
        }

        /// <summary>
        /// ProcessButton is the main process that will provide the logic of the Calculator Game Button
        /// </summary>
        public virtual int ProcessButton(int CurrentNumber)
        {
            throw new NotImplementedException("Function ProcessButton is not implemented");
        }
    }
}
