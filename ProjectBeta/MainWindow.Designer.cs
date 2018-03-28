namespace ProjectBeta
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(556, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQuestionToolStripMenuItem,
            this.saveQuestionsToolStripMenuItem,
            this.loadQuestionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newQuestionToolStripMenuItem
            // 
            this.newQuestionToolStripMenuItem.Name = "newQuestionToolStripMenuItem";
            this.newQuestionToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.newQuestionToolStripMenuItem.Text = "New Question";
            this.newQuestionToolStripMenuItem.Click += new System.EventHandler(this.newQuestionToolStripMenuItem_Click);
            // 
            // saveQuestionsToolStripMenuItem
            // 
            this.saveQuestionsToolStripMenuItem.Name = "saveQuestionsToolStripMenuItem";
            this.saveQuestionsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.saveQuestionsToolStripMenuItem.Text = "Save Questions";
            this.saveQuestionsToolStripMenuItem.Click += new System.EventHandler(this.saveQuestionsToolStripMenuItem_Click);
            // 
            // loadQuestionsToolStripMenuItem
            // 
            this.loadQuestionsToolStripMenuItem.Name = "loadQuestionsToolStripMenuItem";
            this.loadQuestionsToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.loadQuestionsToolStripMenuItem.Text = "Load Questions";
            this.loadQuestionsToolStripMenuItem.Click += new System.EventHandler(this.loadQuestionsToolStripMenuItem_Click);
            // 
            // questionListBox
            // 
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.ItemHeight = 16;
            this.questionListBox.Location = new System.Drawing.Point(46, 46);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(394, 260);
            this.questionListBox.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 412);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadQuestionsToolStripMenuItem;
        private System.Windows.Forms.ListBox questionListBox;
    }
}

