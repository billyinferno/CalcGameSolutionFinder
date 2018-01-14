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
    public partial class frmSolutionFinder : Form
    {
        private Dictionary<string, bool> dctNumber;
        private bool SolutionStart;

        public frmSolutionFinder()
        {
            InitializeComponent();

            // initialize variable needed
            this.dctNumber = new Dictionary<string, bool>();
            this.SolutionStart = false;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            // clear the list
            this.lstNumber.Items.Clear();

            // clear the dictionary list also
            this.dctNumber.Clear();

            // remove the check on the operator
            this.chkPlusMinus.Checked = false;
            this.chkShift.Checked = false;

            // clear the solution list
            this.lstSolution.Items.Clear();

            // clear the current and maximum moves 
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int MaxNumber = 5;
            if (chkPlusMinus.Checked) MaxNumber -= 1;
            if (chkShift.Checked) MaxNumber -= 1;
            if (chkReverse.Checked) MaxNumber -= 1;

            // ensure that the number textbox is already filled
            if ((this.cmbOperator.Text.Trim().Length > 0) && (this.txtNumber.Text.Trim().Length > 0))
            {
                // ensure that this is a number by try to convert it into integer
                int Number;
                try
                {
                    Number = int.Parse(this.txtNumber.Text);

                    // if success then check whether the list box items is already full or not?
                    if (this.lstNumber.Items.Count < MaxNumber && !this.dctNumber.ContainsKey(this.cmbOperator.Text + this.txtNumber.Text))
                    {
                        this.lstNumber.Items.Add(this.cmbOperator.Text + this.txtNumber.Text);
                        this.dctNumber.Add(this.cmbOperator.Text + this.txtNumber.Text, true);
                    }
                    else
                    {
                        // cannot add the data, either already full or already exists before
                        MessageBox.Show("Cannot add number to the list.\nThe list either already too full, or item already exists in list.", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when converting Number.\nERROR: " + ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // combo box or text box is empty
                MessageBox.Show("Please fill the Operator and Number that you will add to the list.", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.SolutionStart == false)
            {
                string ButtonData;
                int CurrentNumber;
                int MaximumMoves;
                int TargetNumber;

                // before we start the solution finder, ensure that all the fields needed is being filled
                if (txtCurrentNumber.Text.Trim().Length <= 0 ||
                    txtMaximumMoves.Text.Trim().Length <= 0 ||
                    txtTargetNumber.Text.Trim().Length <= 0)
                {
                    // text fields is not being filled
                    MessageBox.Show("Current Number, Target Number, and Maximum Moves fields cannot be empty.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // all data is filled, we can perform the validation for all the fields here, by parse the data into integer
                    // and check the value of the integer, whether it bounds on the boundary for the game or not?
                    // (1) check the CurrentNumber
                    try
                    {
                        CurrentNumber = int.Parse(this.txtCurrentNumber.Text);
                        // ensure that CurrentNumber is between -9999 and 9999
                        if (CurrentNumber < -9999 || CurrentNumber > 9999)
                        {
                            MessageBox.Show("Current Number value can be only between -9999 until 9999.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Only number data is allowed for Current Number Fields.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // (2) check the TargetNumber
                    try
                    {
                        TargetNumber = int.Parse(this.txtTargetNumber.Text);
                        // ensure that CurrentNumber is between -9999 and 9999
                        if (TargetNumber < -9999 || TargetNumber > 9999)
                        {
                            MessageBox.Show("Target Number value can be only between -9999 until 9999.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Only number data is allowed for Target Number Fields.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // (3) check the TargetNumber
                    try
                    {
                        MaximumMoves = int.Parse(this.txtMaximumMoves.Text);
                        // ensure that CurrentNumber is between -9999 and 9999
                        if (MaximumMoves < 1 || MaximumMoves > 9)
                        {
                            MessageBox.Show("Maximum Moves value can be only between 1 until 9.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Only number data is allowed for Maximum Moves Fields.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // we should at least have 1 operator, or 1 number
                // otherwise we cannot perform the calculation.
                if (lstNumber.Items.Count <= 0 &&
                    chkPlusMinus.Checked == false &&
                    chkShift.Checked == false)
                {
                    // number and operator is not being filled
                    MessageBox.Show("At least 1 number, or operator need to be filled for the Solution Finder.", "No Number or Operator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // generate the ButtonData string
                    string[] ButtonDataArr = new string[5];
                    int i = 0;

                    // loop through all the item in lstNumber
                    foreach (string itmData in this.lstNumber.Items)
                    {
                        ButtonDataArr[i] = itmData;
                        i += 1;
                    }

                    if (i < 5)
                    {
                        // operator will be always in button number 4 or 5
                        if (chkPlusMinus.Checked)
                        {
                            ButtonDataArr[i] = "PM";
                            i += 1;
                        }
                    }

                    if (i < 5)
                    {
                        if (chkShift.Checked)
                        {
                            ButtonDataArr[i] = "<<";
                            i += 1;
                        }
                    }

                    if (i < 5)
                    {
                        if (chkReverse.Checked)
                        {
                            ButtonDataArr[i] = "RV";
                            i += 1;
                        }
                    }

                    // now join everything in the ButtonData string
                    ButtonData = string.Join(",", ButtonDataArr);
                }

                // set the solution find as true, so user cannot perform any find until this solution finished
                this.SolutionStart = true;

                // set the progress bar value into 0
                this.pBar.Value = 0;
                this.lstSolution.Items.Clear();

                // call the check solution function
                Task.Run(() => CheckSolution(ButtonData, CurrentNumber, TargetNumber, MaximumMoves));
            }
        }

        private void CheckSolution(string ButtonData, int CurrentNumber, int TargetNumber, int MaximumMoves)
        {
            // all data is ready, now we can try to find the solution
            clsSolutionFinder SolutionFinder = new clsSolutionFinder(ButtonData, CurrentNumber, TargetNumber, MaximumMoves);

            // perform the solution finder
            if (SolutionFinder.FindSolution())
            {
                // show the solution
                //foreach (string SolutionData in SolutionFinder.Solution)
                //{
                //    this.lstSolution.Items.Add(SolutionData);
                //}
                MessageBox.Show("Solution Found!", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Solution not Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // set solution start into false, so we can found another solution
            this.SolutionStart = false;
        }

        private void frmSolutionFinder_Load(object sender, EventArgs e)
        {

        }
    }
}
