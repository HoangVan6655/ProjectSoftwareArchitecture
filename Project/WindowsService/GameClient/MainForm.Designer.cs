namespace GameClient
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGame = new System.Windows.Forms.ToolStripMenuItem();
            this.listStudioGame = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategoryGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listGame,
            this.listStudioGame,
            this.listCategoryGame});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(96, 38);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // listGame
            // 
            this.listGame.Name = "listGame";
            this.listGame.Size = new System.Drawing.Size(466, 44);
            this.listGame.Text = "Xem danh sách Game";
            this.listGame.Click += new System.EventHandler(this.listGame_Click);
            // 
            // listStudioGame
            // 
            this.listStudioGame.Name = "listStudioGame";
            this.listStudioGame.Size = new System.Drawing.Size(466, 44);
            this.listStudioGame.Text = "Xem danh sách Studio Game";
            this.listStudioGame.Click += new System.EventHandler(this.listStudioGame_Click);
            // 
            // listCategoryGame
            // 
            this.listCategoryGame.Name = "listCategoryGame";
            this.listCategoryGame.Size = new System.Drawing.Size(466, 44);
            this.listCategoryGame.Text = "Xem danh sách thể loại Game";
            this.listCategoryGame.Click += new System.EventHandler(this.listCategoryGame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listGame;
        private System.Windows.Forms.ToolStripMenuItem listStudioGame;
        private System.Windows.Forms.ToolStripMenuItem listCategoryGame;
    }
}