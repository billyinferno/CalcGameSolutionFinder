namespace CalcGameSolutionFinder
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnImageLst = new System.Windows.Forms.ImageList(this.components);
            this.btnHint = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc4 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnCalc5 = new System.Windows.Forms.Button();
            this.btnCalc3 = new System.Windows.Forms.Button();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.lblMoveCount = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.emotImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblEmot = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
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
            this.btnImageLst.Images.SetKeyName(6, "btnPurple");
            // 
            // btnHint
            // 
            this.btnHint.AutoSize = true;
            this.btnHint.FlatAppearance.BorderSize = 0;
            this.btnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.ImageIndex = 2;
            this.btnHint.ImageList = this.btnImageLst;
            this.btnHint.Location = new System.Drawing.Point(19, 158);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(61, 56);
            this.btnHint.TabIndex = 0;
            this.btnHint.Text = "HINT";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.AutoSize = true;
            this.btnCalc1.FlatAppearance.BorderSize = 0;
            this.btnCalc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.ForeColor = System.Drawing.Color.White;
            this.btnCalc1.ImageIndex = 4;
            this.btnCalc1.ImageList = this.btnImageLst;
            this.btnCalc1.Location = new System.Drawing.Point(85, 158);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(61, 56);
            this.btnCalc1.TabIndex = 1;
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageIndex = 1;
            this.btnClear.ImageList = this.btnImageLst;
            this.btnClear.Location = new System.Drawing.Point(152, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 56);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc4
            // 
            this.btnCalc4.AutoSize = true;
            this.btnCalc4.FlatAppearance.BorderSize = 0;
            this.btnCalc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalc4.ImageIndex = 0;
            this.btnCalc4.ImageList = this.btnImageLst;
            this.btnCalc4.Location = new System.Drawing.Point(152, 220);
            this.btnCalc4.Name = "btnCalc4";
            this.btnCalc4.Size = new System.Drawing.Size(61, 56);
            this.btnCalc4.TabIndex = 5;
            this.btnCalc4.UseVisualStyleBackColor = true;
            this.btnCalc4.Click += new System.EventHandler(this.btnCalc4_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.AutoSize = true;
            this.btnCalc2.FlatAppearance.BorderSize = 0;
            this.btnCalc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc2.ForeColor = System.Drawing.Color.White;
            this.btnCalc2.ImageIndex = 4;
            this.btnCalc2.ImageList = this.btnImageLst;
            this.btnCalc2.Location = new System.Drawing.Point(85, 220);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(61, 56);
            this.btnCalc2.TabIndex = 4;
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // btnCalc5
            // 
            this.btnCalc5.AutoSize = true;
            this.btnCalc5.FlatAppearance.BorderSize = 0;
            this.btnCalc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalc5.ImageIndex = 0;
            this.btnCalc5.ImageList = this.btnImageLst;
            this.btnCalc5.Location = new System.Drawing.Point(152, 282);
            this.btnCalc5.Name = "btnCalc5";
            this.btnCalc5.Size = new System.Drawing.Size(61, 56);
            this.btnCalc5.TabIndex = 8;
            this.btnCalc5.UseVisualStyleBackColor = true;
            this.btnCalc5.Click += new System.EventHandler(this.btnCalc5_Click);
            // 
            // btnCalc3
            // 
            this.btnCalc3.AutoSize = true;
            this.btnCalc3.FlatAppearance.BorderSize = 0;
            this.btnCalc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc3.ForeColor = System.Drawing.Color.White;
            this.btnCalc3.ImageIndex = 4;
            this.btnCalc3.ImageList = this.btnImageLst;
            this.btnCalc3.Location = new System.Drawing.Point(85, 282);
            this.btnCalc3.Name = "btnCalc3";
            this.btnCalc3.Size = new System.Drawing.Size(61, 56);
            this.btnCalc3.TabIndex = 7;
            this.btnCalc3.UseVisualStyleBackColor = true;
            this.btnCalc3.Click += new System.EventHandler(this.btnCalc3_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.AutoSize = true;
            this.btnGoTo.FlatAppearance.BorderSize = 0;
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.ForeColor = System.Drawing.Color.White;
            this.btnGoTo.ImageIndex = 2;
            this.btnGoTo.ImageList = this.btnImageLst;
            this.btnGoTo.Location = new System.Drawing.Point(18, 282);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(61, 56);
            this.btnGoTo.TabIndex = 6;
            this.btnGoTo.Text = "GO";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnSolution
            // 
            this.btnSolution.AutoSize = true;
            this.btnSolution.FlatAppearance.BorderSize = 0;
            this.btnSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolution.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolution.ForeColor = System.Drawing.Color.White;
            this.btnSolution.ImageIndex = 2;
            this.btnSolution.ImageList = this.btnImageLst;
            this.btnSolution.Location = new System.Drawing.Point(18, 220);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(61, 56);
            this.btnSolution.TabIndex = 3;
            this.btnSolution.Text = "SOL";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // lblMoveCount
            // 
            this.lblMoveCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblMoveCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMoveCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.lblMoveCount.Location = new System.Drawing.Point(95, 56);
            this.lblMoveCount.Name = "lblMoveCount";
            this.lblMoveCount.Size = new System.Drawing.Size(48, 16);
            this.lblMoveCount.TabIndex = 10;
            this.lblMoveCount.Text = "0";
            this.lblMoveCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTarget
            // 
            this.lblTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTarget.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.lblTarget.Location = new System.Drawing.Point(152, 56);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(48, 16);
            this.lblTarget.TabIndex = 11;
            this.lblTarget.Text = "0";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImageList
            // 
            this.txtImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("txtImageList.ImageStream")));
            this.txtImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.txtImageList.Images.SetKeyName(0, "8Seg_bg.png");
            this.txtImageList.Images.SetKeyName(1, "8Seg_0.png");
            this.txtImageList.Images.SetKeyName(2, "8Seg_1.png");
            this.txtImageList.Images.SetKeyName(3, "8Seg_2.png");
            this.txtImageList.Images.SetKeyName(4, "8Seg_3.png");
            this.txtImageList.Images.SetKeyName(5, "8Seg_4.png");
            this.txtImageList.Images.SetKeyName(6, "8Seg_5.png");
            this.txtImageList.Images.SetKeyName(7, "8Seg_6.png");
            this.txtImageList.Images.SetKeyName(8, "8Seg_7.png");
            this.txtImageList.Images.SetKeyName(9, "8Seg_8.png");
            this.txtImageList.Images.SetKeyName(10, "8Seg_9.png");
            this.txtImageList.Images.SetKeyName(11, "8Seg_minus.png");
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.ImageIndex = 5;
            this.btnOK.ImageList = this.btnImageLst;
            this.btnOK.Location = new System.Drawing.Point(152, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 56);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // emotImageList
            // 
            this.emotImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("emotImageList.ImageStream")));
            this.emotImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.emotImageList.Images.SetKeyName(0, "emot_happy.png");
            this.emotImageList.Images.SetKeyName(1, "emot_die.png");
            // 
            // lblEmot
            // 
            this.lblEmot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.lblEmot.ImageIndex = 0;
            this.lblEmot.ImageList = this.emotImageList;
            this.lblEmot.Location = new System.Drawing.Point(32, 48);
            this.lblEmot.Name = "lblEmot";
            this.lblEmot.Size = new System.Drawing.Size(48, 22);
            this.lblEmot.TabIndex = 13;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(196)))), ((int)(((byte)(183)))));
            this.lblLevel.Location = new System.Drawing.Point(21, 15);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(125, 15);
            this.lblLevel.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::CalcGameSolutionFinder.Properties.Resources.scrnBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(230, 353);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblEmot);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblMoveCount);
            this.Controls.Add(this.btnCalc5);
            this.Controls.Add(this.btnCalc3);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnCalc4);
            this.Controls.Add(this.btnCalc2);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.btnHint);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Claculator Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList btnImageLst;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc4;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Button btnCalc5;
        private System.Windows.Forms.Button btnCalc3;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblMoveCount;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ImageList txtImageList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ImageList emotImageList;
        private System.Windows.Forms.Label lblEmot;
        private System.Windows.Forms.Label lblLevel;
    }
}

