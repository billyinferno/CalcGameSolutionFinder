namespace CalcGameSolutionFinder
{
    partial class frmSolutionFinder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolutionFinder));
            this.btnImageLst = new System.Windows.Forms.ImageList(this.components);
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImageLst
            // 
            this.btnImageLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("btnImageLst.ImageStream")));
            this.btnImageLst.TransparentColor = System.Drawing.Color.Transparent;
            this.btnImageLst.Images.SetKeyName(0, "btnOrange");
            this.btnImageLst.Images.SetKeyName(1, "btnRed");
            this.btnImageLst.Images.SetKeyName(2, "btnBlue");
            this.btnImageLst.Images.SetKeyName(3, "btnGrey");
            this.btnImageLst.Images.SetKeyName(4, "btnDarkGray");
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "N"});
            this.cmbOperator.Location = new System.Drawing.Point(12, 28);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(40, 27);
            this.cmbOperator.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(58, 28);
            this.txtNumber.MaxLength = 1;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(40, 27);
            this.txtNumber.TabIndex = 8;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.BackColor = System.Drawing.Color.Beige;
            this.btnAddNumber.FlatAppearance.BorderSize = 0;
            this.btnAddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumber.ForeColor = System.Drawing.Color.White;
            this.btnAddNumber.ImageKey = "btnDarkGray";
            this.btnAddNumber.ImageList = this.btnImageLst;
            this.btnAddNumber.Location = new System.Drawing.Point(104, 12);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(59, 57);
            this.btnAddNumber.TabIndex = 9;
            this.btnAddNumber.Text = "ADD";
            this.btnAddNumber.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.ImageKey = "btnOrange";
            this.checkBox5.ImageList = this.btnImageLst;
            this.checkBox5.Location = new System.Drawing.Point(12, 77);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 62);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "1";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.ImageKey = "btnOrange";
            this.checkBox6.ImageList = this.btnImageLst;
            this.checkBox6.Location = new System.Drawing.Point(88, 77);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(70, 62);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "1";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // lstNumber
            // 
            this.lstNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumber.FormattingEnabled = true;
            this.lstNumber.ItemHeight = 14;
            this.lstNumber.Location = new System.Drawing.Point(169, 12);
            this.lstNumber.Name = "lstNumber";
            this.lstNumber.Size = new System.Drawing.Size(151, 60);
            this.lstNumber.TabIndex = 10;
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(326, 12);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 60);
            this.btnClearList.TabIndex = 11;
            this.btnClearList.Text = "CLEAR";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageKey = "btnRed";
            this.button1.ImageList = this.btnImageLst;
            this.button1.Location = new System.Drawing.Point(164, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 57);
            this.button1.TabIndex = 12;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(12, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(389, 200);
            this.listBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "SOLUTION STEP";
            // 
            // frmSolutionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(415, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.lstNumber);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.MaximizeBox = false;
            this.Name = "frmSolutionFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Solution Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList btnImageLst;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}