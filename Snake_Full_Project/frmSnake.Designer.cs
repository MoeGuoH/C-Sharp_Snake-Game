namespace Snake_Full_Project
{
    partial class frmSnake
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.Snake_board = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.版权ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SYS_Update = new System.Windows.Forms.Timer(this.components);
            this.Check_Update = new System.Windows.Forms.Timer(this.components);
            this.Pic_Up = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Snake_board
            // 
            this.Snake_board.Location = new System.Drawing.Point(0, 25);
            this.Snake_board.Name = "Snake_board";
            this.Snake_board.Size = new System.Drawing.Size(800, 600);
            this.Snake_board.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始SToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.游戏ToolStripMenuItem.Text = "游戏(&G)";
            // 
            // 开始SToolStripMenuItem
            // 
            this.开始SToolStripMenuItem.Name = "开始SToolStripMenuItem";
            this.开始SToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.开始SToolStripMenuItem.Text = "开始新游戏(&S)";
            this.开始SToolStripMenuItem.Click += new System.EventHandler(this.开始SToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.版权ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.帮助ToolStripMenuItem.Text = "关于(&A)";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助(&H)";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // 版权ToolStripMenuItem
            // 
            this.版权ToolStripMenuItem.Name = "版权ToolStripMenuItem";
            this.版权ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.版权ToolStripMenuItem.Text = "版权(&C)";
            this.版权ToolStripMenuItem.Click += new System.EventHandler(this.版权ToolStripMenuItem_Click);
            // 
            // SYS_Update
            // 
            this.SYS_Update.Tick += new System.EventHandler(this.SYS_Update_Tick);
            // 
            // Check_Update
            // 
            this.Check_Update.Interval = 1000;
            this.Check_Update.Tick += new System.EventHandler(this.Check_Update_Tick);
            // 
            // Pic_Up
            // 
            this.Pic_Up.Tick += new System.EventHandler(this.Pic_Up_Tick);
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.Snake_board);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Snake_board;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始SToolStripMenuItem;
        private System.Windows.Forms.Timer SYS_Update;
        private System.Windows.Forms.Timer Check_Update;
        private System.Windows.Forms.Timer Pic_Up;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 版权ToolStripMenuItem;
    }
}

