namespace KI.WinForms
{
    partial class IntermediateCAfrm
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
            btnExportIntermediate = new Button();
            cmbIntermediateAlgorithm = new ComboBox();
            txtIntermediateYears = new TextBox();
            txtRootPassword = new TextBox();
            txtIntermediateCN = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            CommonName = new Label();
            btnGenerateIntermediate = new Button();
            btnPfx = new Button();
            lblRootPfxPath = new Label();
            txtRootPfxPath = new TextBox();
            label4 = new Label();
            txtIntermediatePassword = new TextBox();
            SuspendLayout();
            // 
            // btnExportIntermediate
            // 
            btnExportIntermediate.Location = new Point(176, 334);
            btnExportIntermediate.Name = "btnExportIntermediate";
            btnExportIntermediate.Size = new Size(268, 59);
            btnExportIntermediate.TabIndex = 15;
            btnExportIntermediate.Text = "Export Intermediate";
            btnExportIntermediate.UseVisualStyleBackColor = true;
            btnExportIntermediate.Click += btnExportIntermediate_Click;
            // 
            // cmbIntermediateAlgorithm
            // 
            cmbIntermediateAlgorithm.FormattingEnabled = true;
            cmbIntermediateAlgorithm.Location = new Point(188, 217);
            cmbIntermediateAlgorithm.Name = "cmbIntermediateAlgorithm";
            cmbIntermediateAlgorithm.Size = new Size(240, 28);
            cmbIntermediateAlgorithm.TabIndex = 14;
            // 
            // txtIntermediateYears
            // 
            txtIntermediateYears.Location = new Point(188, 138);
            txtIntermediateYears.Name = "txtIntermediateYears";
            txtIntermediateYears.Size = new Size(240, 27);
            txtIntermediateYears.TabIndex = 11;
            // 
            // txtRootPassword
            // 
            txtRootPassword.Location = new Point(188, 51);
            txtRootPassword.Name = "txtRootPassword";
            txtRootPassword.Size = new Size(240, 27);
            txtRootPassword.TabIndex = 12;
            // 
            // txtIntermediateCN
            // 
            txtIntermediateCN.Location = new Point(188, 98);
            txtIntermediateCN.Name = "txtIntermediateCN";
            txtIntermediateCN.Size = new Size(240, 27);
            txtIntermediateCN.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 217);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Algorithm Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 58);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 8;
            label3.Text = "Root Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 145);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "Years :";
            // 
            // CommonName
            // 
            CommonName.AutoSize = true;
            CommonName.Location = new Point(51, 105);
            CommonName.Name = "CommonName";
            CommonName.Size = new Size(117, 20);
            CommonName.TabIndex = 10;
            CommonName.Text = "CommonName :";
            // 
            // btnGenerateIntermediate
            // 
            btnGenerateIntermediate.Location = new Point(176, 260);
            btnGenerateIntermediate.Name = "btnGenerateIntermediate";
            btnGenerateIntermediate.Size = new Size(268, 57);
            btnGenerateIntermediate.TabIndex = 6;
            btnGenerateIntermediate.Text = "Generate Intermediate";
            btnGenerateIntermediate.UseVisualStyleBackColor = true;
            btnGenerateIntermediate.Click += btnGenerateIntermediate_Click;
            // 
            // btnPfx
            // 
            btnPfx.Location = new Point(434, 10);
            btnPfx.Name = "btnPfx";
            btnPfx.Size = new Size(97, 29);
            btnPfx.TabIndex = 18;
            btnPfx.Text = "SelectPfx";
            btnPfx.UseVisualStyleBackColor = true;
            btnPfx.Click += btnPfx_Click;
            // 
            // lblRootPfxPath
            // 
            lblRootPfxPath.AutoSize = true;
            lblRootPfxPath.Location = new Point(72, 25);
            lblRootPfxPath.Name = "lblRootPfxPath";
            lblRootPfxPath.Size = new Size(96, 20);
            lblRootPfxPath.TabIndex = 17;
            lblRootPfxPath.Text = "RootPfxPath :";
            // 
            // txtRootPfxPath
            // 
            txtRootPfxPath.Location = new Point(188, 11);
            txtRootPfxPath.Name = "txtRootPfxPath";
            txtRootPfxPath.Size = new Size(240, 27);
            txtRootPfxPath.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 182);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 8;
            label4.Text = "IntermediatePassword :";
            // 
            // txtIntermediatePassword
            // 
            txtIntermediatePassword.Location = new Point(188, 175);
            txtIntermediatePassword.Name = "txtIntermediatePassword";
            txtIntermediatePassword.Size = new Size(240, 27);
            txtIntermediatePassword.TabIndex = 12;
            // 
            // IntermediateCAfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 504);
            Controls.Add(btnPfx);
            Controls.Add(lblRootPfxPath);
            Controls.Add(txtRootPfxPath);
            Controls.Add(btnExportIntermediate);
            Controls.Add(cmbIntermediateAlgorithm);
            Controls.Add(txtIntermediateYears);
            Controls.Add(txtIntermediatePassword);
            Controls.Add(txtRootPassword);
            Controls.Add(txtIntermediateCN);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CommonName);
            Controls.Add(btnGenerateIntermediate);
            Name = "IntermediateCAfrm";
            Text = "IntermediateCAfrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportIntermediate;
        private ComboBox cmbIntermediateAlgorithm;
        private TextBox txtIntermediateYears;
        private TextBox txtRootPassword;
        private TextBox txtIntermediateCN;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label CommonName;
        private Button btnGenerateIntermediate;
        private Button btnPfx;
        private Label lblRootPfxPath;
        private TextBox txtRootPfxPath;
        private Label label4;
        private TextBox txtIntermediatePassword;
    }
}