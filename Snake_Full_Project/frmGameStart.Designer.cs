namespace Snake_Full_Project
{
    partial class frmGameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameStart));
            this.gbDifficultychoice = new System.Windows.Forms.GroupBox();
            this.rbDIY = new System.Windows.Forms.RadioButton();
            this.rbCN = new System.Windows.Forms.RadioButton();
            this.rbKN = new System.Windows.Forms.RadioButton();
            this.rbPT = new System.Windows.Forms.RadioButton();
            this.rbJD = new System.Windows.Forms.RadioButton();
            this.gbDiy = new System.Windows.Forms.GroupBox();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.tbrSpeed = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbScore = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbFood = new System.Windows.Forms.Label();
            this.lbSea = new System.Windows.Forms.Label();
            this.lbSP = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbTree = new System.Windows.Forms.Label();
            this.tbrFood = new System.Windows.Forms.TrackBar();
            this.tbrSea = new System.Windows.Forms.TrackBar();
            this.tbrSP = new System.Windows.Forms.TrackBar();
            this.tbrGreen = new System.Windows.Forms.TrackBar();
            this.tbrTree = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbDifficultychoice.SuspendLayout();
            this.gbDiy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTree)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDifficultychoice
            // 
            this.gbDifficultychoice.Controls.Add(this.rbDIY);
            this.gbDifficultychoice.Controls.Add(this.rbCN);
            this.gbDifficultychoice.Controls.Add(this.rbKN);
            this.gbDifficultychoice.Controls.Add(this.rbPT);
            this.gbDifficultychoice.Controls.Add(this.rbJD);
            this.gbDifficultychoice.Location = new System.Drawing.Point(12, 12);
            this.gbDifficultychoice.Name = "gbDifficultychoice";
            this.gbDifficultychoice.Size = new System.Drawing.Size(110, 181);
            this.gbDifficultychoice.TabIndex = 0;
            this.gbDifficultychoice.TabStop = false;
            this.gbDifficultychoice.Text = "选择难度";
            // 
            // rbDIY
            // 
            this.rbDIY.AutoSize = true;
            this.rbDIY.Location = new System.Drawing.Point(6, 130);
            this.rbDIY.Name = "rbDIY";
            this.rbDIY.Size = new System.Drawing.Size(83, 16);
            this.rbDIY.TabIndex = 5;
            this.rbDIY.Text = "自定义游戏";
            this.rbDIY.UseVisualStyleBackColor = true;
            this.rbDIY.CheckedChanged += new System.EventHandler(this.rbDIY_CheckedChanged);
            // 
            // rbCN
            // 
            this.rbCN.AutoSize = true;
            this.rbCN.Location = new System.Drawing.Point(6, 18);
            this.rbCN.Name = "rbCN";
            this.rbCN.Size = new System.Drawing.Size(71, 16);
            this.rbCN.TabIndex = 1;
            this.rbCN.Text = "菜鸟模式";
            this.rbCN.UseVisualStyleBackColor = true;
            this.rbCN.CheckedChanged += new System.EventHandler(this.rbCN_CheckedChanged);
            // 
            // rbKN
            // 
            this.rbKN.AutoSize = true;
            this.rbKN.Location = new System.Drawing.Point(6, 102);
            this.rbKN.Name = "rbKN";
            this.rbKN.Size = new System.Drawing.Size(71, 16);
            this.rbKN.TabIndex = 4;
            this.rbKN.Text = "困难模式";
            this.rbKN.UseVisualStyleBackColor = true;
            this.rbKN.CheckedChanged += new System.EventHandler(this.rbKN_CheckedChanged);
            // 
            // rbPT
            // 
            this.rbPT.AutoSize = true;
            this.rbPT.Checked = true;
            this.rbPT.Location = new System.Drawing.Point(6, 74);
            this.rbPT.Name = "rbPT";
            this.rbPT.Size = new System.Drawing.Size(71, 16);
            this.rbPT.TabIndex = 3;
            this.rbPT.TabStop = true;
            this.rbPT.Text = "普通模式";
            this.rbPT.UseVisualStyleBackColor = true;
            this.rbPT.CheckedChanged += new System.EventHandler(this.rbPT_CheckedChanged);
            // 
            // rbJD
            // 
            this.rbJD.AutoSize = true;
            this.rbJD.Location = new System.Drawing.Point(6, 46);
            this.rbJD.Name = "rbJD";
            this.rbJD.Size = new System.Drawing.Size(71, 16);
            this.rbJD.TabIndex = 2;
            this.rbJD.Text = "简单模式";
            this.rbJD.UseVisualStyleBackColor = true;
            this.rbJD.CheckedChanged += new System.EventHandler(this.rbJD_CheckedChanged);
            // 
            // gbDiy
            // 
            this.gbDiy.Controls.Add(this.lbSpeed);
            this.gbDiy.Controls.Add(this.tbrSpeed);
            this.gbDiy.Controls.Add(this.label7);
            this.gbDiy.Controls.Add(this.label13);
            this.gbDiy.Controls.Add(this.txbTime);
            this.gbDiy.Controls.Add(this.txbScore);
            this.gbDiy.Controls.Add(this.label12);
            this.gbDiy.Controls.Add(this.label11);
            this.gbDiy.Controls.Add(this.lbFood);
            this.gbDiy.Controls.Add(this.lbSea);
            this.gbDiy.Controls.Add(this.lbSP);
            this.gbDiy.Controls.Add(this.lbGreen);
            this.gbDiy.Controls.Add(this.lbTree);
            this.gbDiy.Controls.Add(this.tbrFood);
            this.gbDiy.Controls.Add(this.tbrSea);
            this.gbDiy.Controls.Add(this.tbrSP);
            this.gbDiy.Controls.Add(this.tbrGreen);
            this.gbDiy.Controls.Add(this.tbrTree);
            this.gbDiy.Controls.Add(this.label5);
            this.gbDiy.Controls.Add(this.label4);
            this.gbDiy.Controls.Add(this.label3);
            this.gbDiy.Controls.Add(this.label2);
            this.gbDiy.Controls.Add(this.label1);
            this.gbDiy.Enabled = false;
            this.gbDiy.Location = new System.Drawing.Point(128, 12);
            this.gbDiy.Name = "gbDiy";
            this.gbDiy.Size = new System.Drawing.Size(250, 181);
            this.gbDiy.TabIndex = 1;
            this.gbDiy.TabStop = false;
            this.gbDiy.Text = "自定义游戏";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(208, 154);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(11, 12);
            this.lbSpeed.TabIndex = 20;
            this.lbSpeed.Text = "0";
            // 
            // tbrSpeed
            // 
            this.tbrSpeed.AutoSize = false;
            this.tbrSpeed.Location = new System.Drawing.Point(61, 152);
            this.tbrSpeed.Minimum = 1;
            this.tbrSpeed.Name = "tbrSpeed";
            this.tbrSpeed.Size = new System.Drawing.Size(150, 20);
            this.tbrSpeed.TabIndex = 22;
            this.tbrSpeed.Value = 1;
            this.tbrSpeed.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "移动速度：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "Min";
            // 
            // txbTime
            // 
            this.txbTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTime.Location = new System.Drawing.Point(160, 135);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(55, 14);
            this.txbTime.TabIndex = 11;
            this.txbTime.Text = "0";
            this.txbTime.TextChanged += new System.EventHandler(this.txbScore_TextChanged);
            this.txbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbScore_KeyPress);
            // 
            // txbScore
            // 
            this.txbScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbScore.Location = new System.Drawing.Point(65, 135);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(55, 14);
            this.txbScore.TabIndex = 10;
            this.txbScore.Text = "0";
            this.txbScore.TextChanged += new System.EventHandler(this.txbScore_TextChanged);
            this.txbScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbScore_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "目标分数：";
            // 
            // lbFood
            // 
            this.lbFood.AutoSize = true;
            this.lbFood.Location = new System.Drawing.Point(208, 112);
            this.lbFood.Name = "lbFood";
            this.lbFood.Size = new System.Drawing.Size(11, 12);
            this.lbFood.TabIndex = 0;
            this.lbFood.Text = "0";
            // 
            // lbSea
            // 
            this.lbSea.AutoSize = true;
            this.lbSea.Location = new System.Drawing.Point(208, 90);
            this.lbSea.Name = "lbSea";
            this.lbSea.Size = new System.Drawing.Size(11, 12);
            this.lbSea.TabIndex = 0;
            this.lbSea.Text = "0";
            // 
            // lbSP
            // 
            this.lbSP.AutoSize = true;
            this.lbSP.Location = new System.Drawing.Point(208, 68);
            this.lbSP.Name = "lbSP";
            this.lbSP.Size = new System.Drawing.Size(11, 12);
            this.lbSP.TabIndex = 0;
            this.lbSP.Text = "0";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Location = new System.Drawing.Point(208, 46);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(11, 12);
            this.lbGreen.TabIndex = 0;
            this.lbGreen.Text = "0";
            // 
            // lbTree
            // 
            this.lbTree.AutoSize = true;
            this.lbTree.Location = new System.Drawing.Point(208, 22);
            this.lbTree.Name = "lbTree";
            this.lbTree.Size = new System.Drawing.Size(11, 12);
            this.lbTree.TabIndex = 0;
            this.lbTree.Text = "0";
            // 
            // tbrFood
            // 
            this.tbrFood.AutoSize = false;
            this.tbrFood.Location = new System.Drawing.Point(61, 110);
            this.tbrFood.Minimum = 1;
            this.tbrFood.Name = "tbrFood";
            this.tbrFood.Size = new System.Drawing.Size(150, 20);
            this.tbrFood.TabIndex = 9;
            this.tbrFood.Value = 1;
            this.tbrFood.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbrSea
            // 
            this.tbrSea.AutoSize = false;
            this.tbrSea.Location = new System.Drawing.Point(61, 88);
            this.tbrSea.Name = "tbrSea";
            this.tbrSea.Size = new System.Drawing.Size(150, 20);
            this.tbrSea.TabIndex = 8;
            this.tbrSea.Value = 1;
            this.tbrSea.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbrSP
            // 
            this.tbrSP.AutoSize = false;
            this.tbrSP.Location = new System.Drawing.Point(61, 66);
            this.tbrSP.Name = "tbrSP";
            this.tbrSP.Size = new System.Drawing.Size(150, 20);
            this.tbrSP.TabIndex = 7;
            this.tbrSP.Value = 1;
            this.tbrSP.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbrGreen
            // 
            this.tbrGreen.AutoSize = false;
            this.tbrGreen.Location = new System.Drawing.Point(61, 44);
            this.tbrGreen.Name = "tbrGreen";
            this.tbrGreen.Size = new System.Drawing.Size(150, 20);
            this.tbrGreen.TabIndex = 6;
            this.tbrGreen.Value = 1;
            this.tbrGreen.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbrTree
            // 
            this.tbrTree.AutoSize = false;
            this.tbrTree.Location = new System.Drawing.Point(61, 20);
            this.tbrTree.Name = "tbrTree";
            this.tbrTree.Size = new System.Drawing.Size(150, 20);
            this.tbrTree.TabIndex = 5;
            this.tbrTree.Value = 1;
            this.tbrTree.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "可口食物：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "环绕海滩：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "小小山坡：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "十字草丛：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "绿色小树：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(145, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "开始游戏";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmGameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 230);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbDiy);
            this.Controls.Add(this.gbDifficultychoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开始游戏-选择难度";
            this.Shown += new System.EventHandler(this.frmGameStart_Shown);
            this.gbDifficultychoice.ResumeLayout(false);
            this.gbDifficultychoice.PerformLayout();
            this.gbDiy.ResumeLayout(false);
            this.gbDiy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDifficultychoice;
        private System.Windows.Forms.RadioButton rbDIY;
        private System.Windows.Forms.RadioButton rbCN;
        private System.Windows.Forms.RadioButton rbKN;
        private System.Windows.Forms.RadioButton rbPT;
        private System.Windows.Forms.RadioButton rbJD;
        private System.Windows.Forms.GroupBox gbDiy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbrFood;
        private System.Windows.Forms.TrackBar tbrSea;
        private System.Windows.Forms.TrackBar tbrSP;
        private System.Windows.Forms.TrackBar tbrGreen;
        private System.Windows.Forms.TrackBar tbrTree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFood;
        private System.Windows.Forms.Label lbSea;
        private System.Windows.Forms.Label lbSP;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbTree;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbScore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TrackBar tbrSpeed;
        private System.Windows.Forms.Label label7;
    }
}