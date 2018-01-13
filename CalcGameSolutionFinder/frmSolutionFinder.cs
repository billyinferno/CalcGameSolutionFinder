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

        public frmSolutionFinder()
        {
            InitializeComponent();

            // initialize variable needed
            this.dctNumber = new Dictionary<string, bool>();
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
            // ensure that the number textbox is already filled
            if ((this.cmbOperator.Text.Trim().Length > 0) && (this.txtNumber.Text.Trim().Length > 0))
            {
                // ensure that this is a number by try to convert it into integer
                int Number;
                try
                {
                    Number = int.Parse(this.txtNumber.Text);

                    // if success then check whether the list box items is already full or not?
                    if (this.lstNumber.Items.Count < 3 && !this.dctNumber.ContainsKey(this.cmbOperator.Text + this.txtNumber.Text))
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
    }
}
