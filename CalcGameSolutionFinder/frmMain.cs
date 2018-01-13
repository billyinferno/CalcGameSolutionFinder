using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcGameSolutionFinder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int test_num = 10;

            clsAddButton add = new clsAddButton(10);
            clsPlusMinusButton plusMinus = new clsPlusMinusButton();
            clsNumberButton num5 = new clsNumberButton(5);

            Console.WriteLine("Current Number is : " + test_num.ToString());
            
            // test for the class
            test_num = add.ProcessButton(test_num);
            Console.WriteLine("After Add 10      : " + test_num.ToString());
            test_num = plusMinus.ProcessButton(test_num);
            Console.WriteLine("After Plus Minus  : " + test_num.ToString());
            test_num = num5.ProcessButton(test_num);
            Console.WriteLine("After Insert 5    : " + test_num.ToString());

            Console.WriteLine("Final Number is   : " + test_num.ToString());
        }
    }
}
