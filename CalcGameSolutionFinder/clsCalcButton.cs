using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGameSolutionFinder
{
    class clsCalcButton
    {
        /// <summary>
        /// Name is the name of the Child Class that will be inheritance the CalcButton Base Clas
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// ProcessButton is the main process that will provide the logic of the Calculator Game Button
        /// </summary>
        public virtual void ProcessButton() {
            throw new NotImplementedException("Function ProcessButton is not implemented");
        }
    }
}
