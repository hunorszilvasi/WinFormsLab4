namespace WinFormsLab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            databseToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            addKeywordToolStripMenuItem = new ToolStripMenuItem();
            viewKeywordsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            deleteKeywordsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { databseToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // databseToolStripMenuItem
            // 
            databseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, disconnectToolStripMenuItem, addKeywordToolStripMenuItem, viewKeywordsToolStripMenuItem, deleteKeywordsToolStripMenuItem });
            databseToolStripMenuItem.Name = "databseToolStripMenuItem";
            databseToolStripMenuItem.Size = new Size(67, 20);
            databseToolStripMenuItem.Text = "Database";
            databseToolStripMenuItem.Click += databseToolStripMenuItem_Click;
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(180, 22);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(180, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // addKeywordToolStripMenuItem
            // 
            addKeywordToolStripMenuItem.Name = "addKeywordToolStripMenuItem";
            addKeywordToolStripMenuItem.Size = new Size(180, 22);
            addKeywordToolStripMenuItem.Text = "AddKeyword";
            addKeywordToolStripMenuItem.Click += addKeywordToolStripMenuItem_Click;
            // 
            // viewKeywordsToolStripMenuItem
            // 
            viewKeywordsToolStripMenuItem.Name = "viewKeywordsToolStripMenuItem";
            viewKeywordsToolStripMenuItem.Size = new Size(180, 22);
            viewKeywordsToolStripMenuItem.Text = "ViewKeywords";
            viewKeywordsToolStripMenuItem.Click += viewKeywordsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // deleteKeywordsToolStripMenuItem
            // 
            deleteKeywordsToolStripMenuItem.Name = "deleteKeywordsToolStripMenuItem";
            deleteKeywordsToolStripMenuItem.Size = new Size(180, 22);
            deleteKeywordsToolStripMenuItem.Text = "DeleteKeywords";
            deleteKeywordsToolStripMenuItem.Click += deleteKeywordsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem databseToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private ToolStripMenuItem addKeywordToolStripMenuItem;
        private ToolStripMenuItem viewKeywordsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem deleteKeywordsToolStripMenuItem;
    }
}
