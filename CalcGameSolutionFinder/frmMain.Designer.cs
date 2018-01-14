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
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
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
            // btnNum1
            // 
            this.btnNum1.AutoSize = true;
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.ForeColor = System.Drawing.Color.White;
            this.btnNum1.ImageIndex = 4;
            this.btnNum1.ImageList = this.btnImageLst;
            this.btnNum1.Location = new System.Drawing.Point(85, 158);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(61, 56);
            this.btnNum1.TabIndex = 1;
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
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
            // btnOp1
            // 
            this.btnOp1.AutoSize = true;
            this.btnOp1.FlatAppearance.BorderSize = 0;
            this.btnOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOp1.ImageIndex = 0;
            this.btnOp1.ImageList = this.btnImageLst;
            this.btnOp1.Location = new System.Drawing.Point(152, 220);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(61, 56);
            this.btnOp1.TabIndex = 5;
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.btnOp1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.AutoSize = true;
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.ForeColor = System.Drawing.Color.White;
            this.btnNum2.ImageIndex = 4;
            this.btnNum2.ImageList = this.btnImageLst;
            this.btnNum2.Location = new System.Drawing.Point(85, 220);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(61, 56);
            this.btnNum2.TabIndex = 4;
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnOp2
            // 
            this.btnOp2.AutoSize = true;
            this.btnOp2.FlatAppearance.BorderSize = 0;
            this.btnOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOp2.ImageIndex = 0;
            this.btnOp2.ImageList = this.btnImageLst;
            this.btnOp2.Location = new System.Drawing.Point(152, 282);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(61, 56);
            this.btnOp2.TabIndex = 8;
            this.btnOp2.UseVisualStyleBackColor = true;
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.AutoSize = true;
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.ForeColor = System.Drawing.Color.White;
            this.btnNum3.ImageIndex = 4;
            this.btnNum3.ImageList = this.btnImageLst;
            this.btnNum3.Location = new System.Drawing.Point(85, 282);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(61, 56);
            this.btnNum3.TabIndex = 7;
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
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
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnOp1);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNum1);
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
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOp1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnNum3;
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

