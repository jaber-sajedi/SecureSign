namespace KI.WinForms
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            rootToolStripMenuItem = new ToolStripMenuItem();
            rootCAToolStripMenuItem = new ToolStripMenuItem();
            intermediateCAToolStripMenuItem = new ToolStripMenuItem();
            generateEndEntityToolStripMenuItem = new ToolStripMenuItem();
            signFileToolStripMenuItem = new ToolStripMenuItem();
            verifyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { rootToolStripMenuItem, generateEndEntityToolStripMenuItem, signFileToolStripMenuItem, verifyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // rootToolStripMenuItem
            // 
            rootToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rootCAToolStripMenuItem, intermediateCAToolStripMenuItem });
            rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            rootToolStripMenuItem.Size = new Size(42, 24);
            rootToolStripMenuItem.Text = "CA";
            rootToolStripMenuItem.Click += rootToolStripMenuItem_Click;
            // 
            // rootCAToolStripMenuItem
            // 
            rootCAToolStripMenuItem.Name = "rootCAToolStripMenuItem";
            rootCAToolStripMenuItem.Size = new Size(202, 26);
            rootCAToolStripMenuItem.Text = "Root-CA";
            rootCAToolStripMenuItem.Click += rootCAToolStripMenuItem_Click;
            // 
            // intermediateCAToolStripMenuItem
            // 
            intermediateCAToolStripMenuItem.Name = "intermediateCAToolStripMenuItem";
            intermediateCAToolStripMenuItem.Size = new Size(202, 26);
            intermediateCAToolStripMenuItem.Text = "Intermediate-CA";
            intermediateCAToolStripMenuItem.Click += intermediateCAToolStripMenuItem_Click;
            // 
            // generateEndEntityToolStripMenuItem
            // 
            generateEndEntityToolStripMenuItem.Name = "generateEndEntityToolStripMenuItem";
            generateEndEntityToolStripMenuItem.Size = new Size(145, 24);
            generateEndEntityToolStripMenuItem.Text = "GenerateEndEntity";
            generateEndEntityToolStripMenuItem.Click += generateEndEntityToolStripMenuItem_Click;
            // 
            // signFileToolStripMenuItem
            // 
            signFileToolStripMenuItem.Name = "signFileToolStripMenuItem";
            signFileToolStripMenuItem.Size = new Size(75, 24);
            signFileToolStripMenuItem.Text = "SignFile";
            signFileToolStripMenuItem.Click += signFileToolStripMenuItem_Click;
            // 
            // verifyToolStripMenuItem
            // 
            verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            verifyToolStripMenuItem.Size = new Size(60, 24);
            verifyToolStripMenuItem.Text = "Verify";
            verifyToolStripMenuItem.Click += verifyToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem rootToolStripMenuItem;
        private ToolStripMenuItem rootCAToolStripMenuItem;
        private ToolStripMenuItem intermediateCAToolStripMenuItem;
        private ToolStripMenuItem generateEndEntityToolStripMenuItem;
        private ToolStripMenuItem signFileToolStripMenuItem;
        private ToolStripMenuItem verifyToolStripMenuItem;
    }
}