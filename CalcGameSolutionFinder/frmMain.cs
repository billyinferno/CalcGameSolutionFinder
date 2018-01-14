using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalcGameSolutionFinder
{
    public partial class frmMain : Form
    {
        private frmSolutionFinder solFinder = new frmSolutionFinder();

        private List<clsGameData> GameData;
        private int CurrentGameData;
        private bool IsLoadGameData;

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
        private clsReverseButton btnReverse = new clsReverseButton();

        private Label[] lblSegment = new Label[5];

        #region UserFunction
        /// <summary>
        /// Constructor of the Main Game form.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            this.InitializeSegment();

            // load the game data
            this.LoadGameFile();

            // set the is load game data into true, so we will load the game data
            // when we run the application for the first time
            this.IsLoadGameData = true;

            // the Hint Number given is only 2, and it will be increase every 10 level
            this.HintsNumber = 2;
        }

        /// <summary>
        /// This function will load the GameFile.txt from the same location as the .exe files, and generate the list of GameData.
        /// If the GameData is failed to load, it will be logged to the Console Window.
        /// </summary>
        private void LoadGameFile()
        {
            // check if the Game File is exists or not?
            if (File.Exists("GameFile.txt")) {
                // initialize the GameData
                this.GameData = new List<clsGameData>();

                // load the game file
                string[] lines = File.ReadAllLines("GameFile.txt");
                foreach (string line in lines)
                {
                    if (line.Trim().Length > 0)
                    {
                        // create new game data
                        clsGameData newGameData = new clsGameData(line);
                        if (newGameData.IsLoaded)
                        {
                            this.GameData.Add(newGameData);
                        }
                    }
                }

                // check if we got game data or not?
                if (this.GameData.Count <= 0)
                {
                    // add dummy data
                    MessageBox.Show("Cannot load GameFile data, load Dummy Game.", "Load Game Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // dummy data (this should be loaded from game file)
                    clsGameData newGameData = new clsGameData("+1,+2,N3,+/-,<<#100#10333#4");

                    // add dummy data to the list
                    this.GameData = new List<clsGameData>();
                    this.GameData.Add(newGameData);
                }
            }
            else
            {
                // show message box
                MessageBox.Show("Cannot found GameFile data, load Dummy Game.", "No Game Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // dummy data (this should be loaded from game file)
                clsGameData newGameData = new clsGameData("+1,+2,N3,+/-,<<#100#10333#4");

                // add dummy data to the list
                this.GameData = new List<clsGameData>();
                this.GameData.Add(newGameData);
            }

            // show the first game data
            this.CurrentGameData = -1;
        }

        /// <summary>
        /// This function will get the Game Data that we loaded from the Game Data File.
        /// The Game Data will have at least one data, since if we cannot load the Game Data File, we will
        /// insert a dummy game data to ensure that at least 1 game data is available on the list.
        /// </summary>
        private bool GetGameData()
        {
            // // check whether we need to add the game data or not?
            if (IsLoadGameData)
            {
                this.CurrentGameData += 1;

                // check if we already got 10 level finished, if yes add 1 to the hint number
                if ((this.CurrentGameData + 1) % 10 == 0)
                {
                    // if currently Hints Number is less or equal with zero, it means that
                    // the hint button is disabled, so now enabled the button before we add
                    // the hint number.
                    if (this.HintsNumber <= 0)
                    {
                        this.btnHint.Enabled = true;
                    }

                    // add the hint number.
                    this.HintsNumber += 1;
                }
            }

            // check if the current game data number is below or same as the
            // length of the game data?
            if (this.CurrentGameData < this.GameData.Count)
            {
                this.ButtonString = this.GameData[this.CurrentGameData].ButtonString;
                this.CurrentNumber = this.GameData[this.CurrentGameData].CurrentNumber;
                this.TargetNumber = this.GameData[this.CurrentGameData].TargetNumber;
                this.MaximumMoves = this.GameData[this.CurrentGameData].MaximumMoves;
                return true;
            }
            else
            {
                // No more game data
                MessageBox.Show("No More Game Data!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// Start the Calculator Game.
        /// Here we will try to get the game data, load all the button and initialize variable
        /// needed for the game.
        /// </summary>
        private void GameStart()
        {
            // get the game data
            if (!this.GetGameData())
            {
                return;
            }

            // load the button
            this.LoadButton();

            // set the target number
            this.lblTarget.Text = this.TargetNumber.ToString();

            // set the emoticon image
            this.lblEmot.ImageIndex = 0;

            // refresh the display everytime game starts
            this.RefreshDisplay();

            // enabled all the button and hide the OK button
            this.EnableAllButton();
            this.btnOK.Visible = false;
        }

        /// <summary>
        /// This will disable all the button on the Game form.
        /// </summary>
        private void DisableAllButton()
        {
            if (this.HintsNumber > 0)
            {
                this.btnHint.Enabled = false;
            }
            this.btnGoTo.Enabled = false;
            this.btnCalc1.Enabled = false;
            this.btnCalc2.Enabled = false;
            this.btnCalc3.Enabled = false;
            this.btnCalc4.Enabled = false;
            this.btnCalc5.Enabled = false;
            this.btnClear.Enabled = false;
        }

        /// <summary>
        /// This will enable all the button on the Game form.
        /// </summary>
        private void EnableAllButton()
        {
            if (this.HintsNumber > 0)
            {
                this.btnHint.Enabled = true;
            }
            this.btnGoTo.Enabled = true;
            this.btnCalc1.Enabled = true;
            this.btnCalc2.Enabled = true;
            this.btnCalc3.Enabled = true;
            this.btnCalc4.Enabled = true;
            this.btnCalc5.Enabled = true;
            this.btnClear.Enabled = true;
        }

        /// <summary>
        /// This function is used to refresh all the components of the game,
        /// such as Label, Segment Display, etc.
        /// </summary>
        private void RefreshDisplay()
        {
            // refresh the display everytime event occurs
            this.lblMoveCount.Text = this.MaximumMoves.ToString();
            this.lblLevel.Text = "LEVEL : " + (this.CurrentGameData + 1).ToString();
            this.WriteSegment();

            // check if we already reach the target, if not check the moves?
            // whether we can still proceed the game or not?
            if (this.CurrentNumber == this.TargetNumber)
            {
                // target is achieved, disabled all the button and bring the OK button
                this.DisableAllButton();

                // to load the next stage
                this.btnOK.Visible = true;

                // load the game data
                this.IsLoadGameData = true;
            }
            else
            {
                // check whether we still have moves or not?
                if (this.MaximumMoves <= 0)
                {
                    // no more moves, put as game over
                    // disable all button, except the clear button
                    this.DisableAllButton();
                    this.btnClear.Enabled = true;

                    // show the died emoticon
                    this.lblEmot.ImageIndex = 1;

                    // no need to load the game data
                    this.IsLoadGameData = false;
                }
            }
        }

        /// <summary>
        /// Initialize the Segment Data that will be used to showed the Current Number
        /// on the Game form.
        /// </summary>
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

        /// <summary>
        /// Write Segment Data on the Game form based on the Current Number.
        /// </summary>
        private void WriteSegment()
        {
            // convert current number into string
            string sCurrentNumber = this.CurrentNumber.ToString();
            string SegmentData;

            // remove all the segment data first
            for (int i = 0; i < 5; i++)
            {
                this.lblSegment[i].ImageIndex = 0;
            }

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
            string btnLabel;
            int btnImageIndex = 0;

            // loop throught the button array
            for (int i = btnArr.GetLowerBound(0); i <= btnArr.GetUpperBound(0); i++)
            {
                // check if button array have value or not?
                // if not then it means that this button is disabled.
                if (btnArr[i].Length > 0)
                {
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
                        case "R":
                            btnLabel = btnArr[i];
                            break;
                        case "#":
                            btnLabel = "*-" + btnArr[i].Substring(1, btnArr[i].Length - 1);
                            break;
                        case "\\":
                            btnLabel = "/-" + btnArr[i].Substring(1, btnArr[i].Length - 1);
                            break;
                        case "N":
                            // for number we only need to add the number no need to add the "N"
                            btnLabel = btnArr[i].Substring(1, btnArr[i].Length - 1);
                            break;
                        default:
                            throw new Exception("Unknown Button");
                    }

                    switch (chkOperator)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "#":
                        case "\\":
                            btnImageIndex = 4;
                            break;
                        case "N":
                            btnImageIndex = 6;
                            break;
                        case "P":
                        case "<":
                        case "R":
                            btnImageIndex = 0;
                            break;
                    }

                    // write the button
                    switch (i)
                    {
                        case 0:
                            btnCalc1.Text = btnLabel;
                            btnCalc1.Tag = btnArr[i];
                            btnCalc1.ImageIndex = btnImageIndex;
                            break;
                        case 1:
                            btnCalc2.Text = btnLabel;
                            btnCalc2.Tag = btnArr[i];
                            btnCalc2.ImageIndex = btnImageIndex;
                            break;
                        case 2:
                            btnCalc3.Text = btnLabel;
                            btnCalc3.Tag = btnArr[i];
                            btnCalc3.ImageIndex = btnImageIndex;
                            break;
                        case 3:
                            btnCalc4.Text = btnLabel;
                            btnCalc4.Tag = btnArr[i];
                            btnCalc4.ImageIndex = btnImageIndex;
                            break;
                        case 4:
                            btnCalc5.Text = btnLabel;
                            btnCalc5.Tag = btnArr[i];
                            btnCalc5.ImageIndex = btnImageIndex;
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
                            btnCalc1.Text = "";
                            btnCalc1.Enabled = false;
                            btnCalc1.ImageIndex = 3;
                            break;
                        case 1:
                            btnCalc2.Text = "";
                            btnCalc2.Enabled = false;
                            btnCalc2.ImageIndex = 3;
                            break;
                        case 2:
                            btnCalc3.Text = "";
                            btnCalc3.Enabled = false;
                            btnCalc3.ImageIndex = 3;
                            break;
                        case 3:
                            btnCalc4.Text = "";
                            btnCalc4.Enabled = false;
                            btnCalc4.ImageIndex = 3;
                            break;
                        case 4:
                            btnCalc5.Text = "";
                            btnCalc5.Enabled = false;
                            btnCalc5.ImageIndex = 3;
                            break;
                        default:
                            throw new Exception("Button Number > 5, Maximum Button Number is 5");
                    }
                }
            }
        }

        /// <summary>
        /// Main function of the Button Click, that will determine what kind of action
        /// that will be performed when the Button Clicked.
        /// </summary>
        /// <param name="ButtonTag">Operator that will be performed</param>
        /// <param name="ButtonText">Number that will be processed</param>
        private void ProcessButton(string ButtonTag, string ButtonText)
        {
            int Number = 0;

            // here we will parse the Button Tag and Button Text to knew what kind of
            // process that we will perform on the game?
            switch (ButtonTag.Substring(0,1))
            {
                case "+":
                    int.TryParse(ButtonTag.Substring(1,ButtonTag.Length - 1), out Number);
                    this.btnAdd.Number = Number;
                    this.CurrentNumber = this.btnAdd.ProcessButton(this.CurrentNumber);
                    break;
                case "-":
                    int.TryParse(ButtonTag.Substring(1, ButtonTag.Length - 1), out Number);
                    this.btnMinus.Number = Number;
                    this.CurrentNumber = this.btnMinus.ProcessButton(this.CurrentNumber);
                    break;
                case "*":
                case "#":
                    int.TryParse(ButtonTag.Substring(1, ButtonTag.Length - 1), out Number);
                    if (ButtonTag.Substring(0, 1) == "#")
                    {
                        Number *= -1;
                    }
                    this.btnMultiply.Number = Number;
                    this.CurrentNumber = this.btnMultiply.ProcessButton(this.CurrentNumber);
                    break;
                case "/":
                case "\\":
                    int.TryParse(ButtonTag.Substring(1, ButtonTag.Length - 1), out Number);
                    if (ButtonTag.Substring(0, 1) == "\\")
                    {
                        Number *= -1;
                    }
                    this.btnDivide.Number = Number;
                    this.CurrentNumber = this.btnDivide.ProcessButton(this.CurrentNumber);
                    break;
                case "P":
                    this.CurrentNumber = this.btnPlusMinus.ProcessButton(this.CurrentNumber);
                    break;
                case "<":
                    this.CurrentNumber = this.btnShift.ProcessButton(this.CurrentNumber);
                    break;
                case "R":
                    this.CurrentNumber = this.btnReverse.ProcessButton(this.CurrentNumber);
                    break;
                case "N":
                    int.TryParse(ButtonTag.Substring(1, ButtonTag.Length - 1), out Number);
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
        #endregion

        #region FormFunction
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

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnCalc1.Tag.ToString(), btnCalc1.Text);
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnCalc2.Tag.ToString(), btnCalc2.Text);
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnCalc3.Tag.ToString(), btnCalc3.Text);
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnCalc4.Tag.ToString(), btnCalc4.Text);
        }

        private void btnCalc5_Click(object sender, EventArgs e)
        {
            this.ProcessButton(btnCalc5.Tag.ToString(), btnCalc5.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear everything
            // no need to load the game data
            this.IsLoadGameData = false;
            this.GameStart();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // load the next game data
            // and start the game again
            this.IsLoadGameData = true;
            this.GameStart();
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            // show the solution form
            solFinder.ShowDialog();
        }
        #endregion

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            // directly go to some level number
            ///TODO:
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            // directly click the button based on the hint listed at the game data
            if (this.HintsNumber > 0)
            {
                int HintPosition = this.GameData[this.CurrentGameData].MaximumMoves - this.MaximumMoves;

                // check if Hint Data is more than HintPosition?
                if (this.GameData[this.CurrentGameData].HintData.Length > HintPosition)
                {
                    // process the hints data, check which button is equal with the Hint
                    if (btnCalc1.Text == this.GameData[this.CurrentGameData].HintData[HintPosition])
                    {
                        this.btnCalc1_Click(sender, e);
                    }
                    else if (btnCalc2.Text == this.GameData[this.CurrentGameData].HintData[HintPosition])
                    {
                        this.btnCalc2_Click(sender, e);
                    }
                    else if (btnCalc3.Text == this.GameData[this.CurrentGameData].HintData[HintPosition])
                    {
                        this.btnCalc3_Click(sender, e);
                    }
                    else if (btnCalc4.Text == this.GameData[this.CurrentGameData].HintData[HintPosition])
                    {
                        this.btnCalc4_Click(sender, e);
                    }
                    else if (btnCalc5.Text == this.GameData[this.CurrentGameData].HintData[HintPosition])
                    {
                        this.btnCalc5_Click(sender, e);
                    }

                    // substract hint number, since we already used the hint
                    this.HintsNumber -= 1;

                    // if hint number is already 0, then disabled the hint button
                    if (this.HintsNumber <= 0)
                    {
                        this.btnHint.Enabled = false;
                    }
                }
            }
        }
    }
}
