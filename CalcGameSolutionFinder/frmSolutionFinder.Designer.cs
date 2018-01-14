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
            this.lstNumber = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstSolution = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentNumber = new System.Windows.Forms.TextBox();
            this.txtTargetNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.txtMaximumMoves = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateGameFile = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.chkPlusMinus = new System.Windows.Forms.CheckBox();
            this.chkShift = new System.Windows.Forms.CheckBox();
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
            this.btnImageLst.Images.SetKeyName(5, "btnGreen");
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
            "#",
            "/",
            "\\",
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
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
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
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Beige;
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.ImageKey = "btnGreen";
            this.btnGo.ImageList = this.btnImageLst;
            this.btnGo.Location = new System.Drawing.Point(326, 138);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(59, 57);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstSolution
            // 
            this.lstSolution.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSolution.FormattingEnabled = true;
            this.lstSolution.ItemHeight = 14;
            this.lstSolution.Location = new System.Drawing.Point(12, 201);
            this.lstSolution.Name = "lstSolution";
            this.lstSolution.Size = new System.Drawing.Size(373, 144);
            this.lstSolution.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "SOLUTION STEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CURRENT";
            // 
            // txtCurrentNumber
            // 
            this.txtCurrentNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentNumber.Location = new System.Drawing.Point(232, 78);
            this.txtCurrentNumber.MaxLength = 5;
            this.txtCurrentNumber.Name = "txtCurrentNumber";
            this.txtCurrentNumber.Size = new System.Drawing.Size(88, 27);
            this.txtCurrentNumber.TabIndex = 16;
            // 
            // txtTargetNumber
            // 
            this.txtTargetNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetNumber.Location = new System.Drawing.Point(232, 112);
            this.txtTargetNumber.MaxLength = 5;
            this.txtTargetNumber.Name = "txtTargetNumber";
            this.txtTargetNumber.Size = new System.Drawing.Size(88, 27);
            this.txtTargetNumber.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "TARGET";
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.Beige;
            this.btnClearList.FlatAppearance.BorderSize = 0;
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.ForeColor = System.Drawing.Color.White;
            this.btnClearList.ImageKey = "btnRed";
            this.btnClearList.ImageList = this.btnImageLst;
            this.btnClearList.Location = new System.Drawing.Point(326, 12);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(59, 57);
            this.btnClearList.TabIndex = 19;
            this.btnClearList.Text = "CLR";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // txtMaximumMoves
            // 
            this.txtMaximumMoves.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximumMoves.Location = new System.Drawing.Point(232, 145);
            this.txtMaximumMoves.MaxLength = 1;
            this.txtMaximumMoves.Name = "txtMaximumMoves";
            this.txtMaximumMoves.Size = new System.Drawing.Size(88, 27);
            this.txtMaximumMoves.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "MOVES";
            // 
            // btnGenerateGameFile
            // 
            this.btnGenerateGameFile.BackColor = System.Drawing.Color.Beige;
            this.btnGenerateGameFile.FlatAppearance.BorderSize = 0;
            this.btnGenerateGameFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGameFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateGameFile.ForeColor = System.Drawing.Color.White;
            this.btnGenerateGameFile.ImageKey = "btnBlue";
            this.btnGenerateGameFile.ImageList = this.btnImageLst;
            this.btnGenerateGameFile.Location = new System.Drawing.Point(326, 75);
            this.btnGenerateGameFile.Name = "btnGenerateGameFile";
            this.btnGenerateGameFile.Size = new System.Drawing.Size(59, 57);
            this.btnGenerateGameFile.TabIndex = 22;
            this.btnGenerateGameFile.Text = "GEN";
            this.btnGenerateGameFile.UseVisualStyleBackColor = false;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 351);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(373, 23);
            this.pBar.TabIndex = 23;
            // 
            // chkPlusMinus
            // 
            this.chkPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPlusMinus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlusMinus.ForeColor = System.Drawing.Color.White;
            this.chkPlusMinus.ImageKey = "btnOrange";
            this.chkPlusMinus.ImageList = this.btnImageLst;
            this.chkPlusMinus.Location = new System.Drawing.Point(12, 77);
            this.chkPlusMinus.Name = "chkPlusMinus";
            this.chkPlusMinus.Size = new System.Drawing.Size(70, 62);
            this.chkPlusMinus.TabIndex = 5;
            this.chkPlusMinus.Text = "+/-";
            this.chkPlusMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPlusMinus.UseVisualStyleBackColor = true;
            // 
            // chkShift
            // 
            this.chkShift.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkShift.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShift.ForeColor = System.Drawing.Color.White;
            this.chkShift.ImageKey = "btnOrange";
            this.chkShift.ImageList = this.btnImageLst;
            this.chkShift.Location = new System.Drawing.Point(88, 77);
            this.chkShift.Name = "chkShift";
            this.chkShift.Size = new System.Drawing.Size(70, 62);
            this.chkShift.TabIndex = 6;
            this.chkShift.Text = "<<";
            this.chkShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShift.UseVisualStyleBackColor = true;
            // 
            // frmSolutionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(397, 385);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btnGenerateGameFile);
            this.Controls.Add(this.txtMaximumMoves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.txtTargetNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSolution);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lstNumber);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.chkShift);
            this.Controls.Add(this.chkPlusMinus);
            this.MaximizeBox = false;
            this.Name = "frmSolutionFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Solution Finder";
            this.Load += new System.EventHandler(this.frmSolutionFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList btnImageLst;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.ListBox lstNumber;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lstSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentNumber;
        private System.Windows.Forms.TextBox txtTargetNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox txtMaximumMoves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateGameFile;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.CheckBox chkPlusMinus;
        private System.Windows.Forms.CheckBox chkShift;
    }
}