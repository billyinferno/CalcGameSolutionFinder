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
        private bool IsGameOver;
        private bool IsTargetAchieved;
        private int HintsNumber;

        private string ButtonString;
        private int CurrentNumber;
        private int TargetNumber;
        private int MaximumMoves;

        private clsNumberButton btnNumber = new clsNumberButton(0);
        private clsAddButton btnAdd = new clsAddButton(0);
        private clsMinusButton btnMinus = new clsMinusButton(0);
        private clsDivideButton btnDivide = new clsDivideButton(0);
        private clsMultiplyButton btnMultiply = new clsMultiplyButton(0);
        private clsPlusMinusButton btnPlusMinus = new clsPlusMinusButton();
        private clsShiftButton btnShift = new clsShiftButton();

        private Label[] lblSegment = new Label[5];

        public frmMain()
        {
            InitializeComponent();

            this.InitializeSegment();
        }

        private void GameStart()
        {
            // dummy data (this should be loaded from game file)
            this.ButtonString = "+1,+2,N3,+/-,<<";
            this.CurrentNumber = 100;
            this.MaximumMoves = 4;
            this.TargetNumber = 10333;

            // load the button
            this.LoadButton();

            // set the target number
            this.lblTarget.Text = this.TargetNumber.ToString();

            // set the game over and target achieve as false
            this.IsGameOver = false;
            this.IsTargetAchieved = false;

            // refresh the display everytime game start
            this.RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            // refresh the display everytime event occurs
            this.lblMoveCount.Text = this.MaximumMoves.ToString();
            this.WriteSegment();

            // check if we already reach the target, if not check the moves?
            // whether we can still proceed the game or not?
            if (this.CurrentNumber == this.TargetNumber)
            {
                this.IsTargetAchieved = true;
            }
            else
            {
                // check whether we still have moves or not?
                if (this.MaximumMoves <= 0)
                {
                    // no more moves, put as game over
                    this.IsGameOver = true;
                }
            }
        }

        private void InitializeSegment()
        {
            int x = 30;
            int y = 82;

            // loop thru all the label, and initialize the text and the position
            // of each label
            for (int i = 0; i < 5; i++)
            {
                // format the label
                this.lblSegment[i] = new Label();
                this.lblSegment[i].Text = "";
                this.lblSegment[i].Location = new Point(x, y);
                this.lblSegment[i].ImageList = this.txtImageList;
                this.lblSegment[i].ImageIndex = 0;
                this.lblSegment[i].AutoSize = false;
                this.lblSegment[i].Size = new Size(29, 40);
                this.lblSegment[i].Visible = true;
                this.lblSegment[i].BringToFront();

                // add controls to the form
                this.Controls.Add(this.lblSegment[i]);

                // move to the next location
                x += 35;
            }
        }

        private void WriteSegment()
        {
            // convert current number into string
            string sCurrentNumber = this.CurrentNumber.ToString();
            string SegmentData;

            // maximum length should be 5
            if (sCurrentNumber.Length > 5)
            {
                throw new Exception("Current Number should be between -9999 to 9999");
            }

            // loop through all the data on the string
            for (int i = 0; i < sCurrentNumber.Length; i++)
            {
                SegmentData = sCurrentNumber.Substring(i, 1);
                switch (SegmentData)
                {
                    case "-":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 11;
                        break;
                    case "0":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 1;
                        break;
                    case "1":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 2;
                        break;
                    case "2":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 3;
                        break;
                    case "3":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 4;
                        break;
                    case "4":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 5;
                        break;
                    case "5":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 6;
                        break;
                    case "6":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 7;
                        break;
                    case "7":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 8;
                        break;
                    case "8":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 9;
                        break;
                    case "9":
                        this.lblSegment[5 - sCurrentNumber.Length + i].ImageIndex = 10;
                        break;
                    default:
                        throw new Exception("Unknown Segment Data");
                }
            }
        }

        /// <summary>
        /// Load the correct button data to the Form, based on the ButtonString that loaded from the file.
        /// </summary>
        private void LoadButton()
        {
            // here we will split the button string and load the corresponding
            // button on the form.
            string[] btnArr = this.ButtonString.Split(new string[] { "," }, StringSplitOptions.None);
            string chkOperator;

            // loop throught the button array
            for (int i = btnArr.GetLowerBound(0); i <= btnArr.GetUpperBound(0); i++)
            {
                // check if button array have value or not?
                // if not then it means that this button is disabled.
                if (btnArr[i].Length > 0) {
                    // check if the first byte is operator?
                    chkOperator = btnArr[i].Substring(0, 1);
                    switch (chkOperator)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                        case "P":
                        case "<":
                            // continue the process
                            break;
                        case "N":
                            // for number we only need to add the number no need to add the "N"
                            btnArr[i] = btnArr[i].Substring(1, 1);
                            break;
                        default:
                            throw new Exception("Unknown Button");
                    }

                    // write the button
                    switch (i)
                    {
                        case 0:
                            btnNum1.Text = btnArr[i];
                            btnNum1.Tag = chkOperator;
                            break;
                        case 1:
                            btnNum2.Text = btnArr[i];
                            btnNum2.Tag = chkOperator;
                            break;
                        case 2:
                            btnNum3.Text = btnArr[i];
                            btnNum3.Tag = chkOperator;
                            break;
                        case 3:
                            btnOp1.Text = btnArr[i];
                            btnOp1.Tag = chkOperator;
                            break;
                        case 4:
                            btnOp2.Text = btnArr[i];
                            btnOp2.Tag = chkOperator;
                            break;
                        default:
                            throw new Exception("Button Number > 5, Maximum Button Number is 5");
                    }
                }
                else
                {
                    // button should be disabled
                    switch (i)
                    {
                        case 0:
                            btnNum1.Enabled = false;
                            btnNum1.ImageIndex = 3;
                            break;
                        case 1:
                            btnNum2.Enabled = false;
                            btnNum2.ImageIndex = 3;
                            break;
                        case 2:
                            btnNum3.Enabled = false;
                            btnNum3.ImageIndex = 3;
                            break;
                        case 3:
                            btnOp1.Enabled = false;
                            btnOp1.ImageIndex = 3;
                            break;
                        case 4:
                            btnOp2.Enabled = false;
                            btnOp2.ImageIndex = 3;
                            break;
                        default:
                            throw new Exception("Button Number > 5, Maximum Button Number is 5");
                    }
                }
            }
        }

        private void ProcessButton(string ButtonTag, string ButtonText)
        {
            int Number = 0;

            // here we will parse the Button Tag and Button Text to knew what kind of
            // process that we will perform on the game?
            switch (ButtonTag)
            {
                case "+":
                    int.TryParse(ButtonText.Substring(1,1), out Number);
                    this.btnAdd.Number = Number;
                    this.CurrentNumber = this.btnAdd.ProcessButton(this.CurrentNumber);
                    break;
                case "-":
                    int.TryParse(ButtonText.Substring(1, 1), out Number);
                    this.btnMinus.Number = Number;
                    this.CurrentNumber = this.btnMinus.ProcessButton(this.CurrentNumber);
                    break;
                case "*":
                    int.TryParse(ButtonText.Substring(1, 1), out Number);
                    this.btnMultiply.Number = Number;
                    this.CurrentNumber = this.btnMultiply.ProcessButton(this.CurrentNumber);
                    break;
                case "/":
                    int.TryParse(ButtonText.Substring(1, 1), out Number);
                    this.btnDivide.Number = Number;
                    this.CurrentNumber = this.btnDivide.ProcessButton(this.CurrentNumber);
                    break;
                case "P":
                    this.CurrentNumber = this.btnPlusMinus.ProcessButton(this.CurrentNumber);
                    break;
                case "<":
                    this.CurrentNumber = this.btnShift.ProcessButton(this.CurrentNumber);
                    break;
                case "N":
                    int.TryParse(ButtonText, out Number);
                    this.btnNumber.Number = Number;
                    this.CurrentNumber = this.btnNumber.ProcessButton(this.CurrentNumber);
                    break;
                default:
                    throw new Exception("Unknown Button Tag");
            }

            // Substract the moves number
            this.MaximumMoves -= 1;

            // refresh the display
            this.RefreshDisplay();
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

            string test = "12345";
            test = test.Substring(0, (test.Length - 1));
            Console.WriteLine("Test Line : " + test);

            this.GameStart();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnNum1.Tag.ToString(), btnNum1.Text);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnNum2.Tag.ToString(), btnNum2.Text);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnNum3.Tag.ToString(), btnNum3.Text);
        }

        private void btnOp1_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnOp1.Tag.ToString(), btnOp1.Text);
        }

        private void btnOp2_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnOp2.Tag.ToString(), btnOp2.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear everything
            this.GameStart();
        }
    }
}
