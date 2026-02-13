namespace KI.WinForms
{
    partial class RootCAfrm
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
            btnCreateRootCertificate = new Button();
            CommonName = new Label();
            txtCommonName = new TextBox();
            label1 = new Label();
            txtRootYears = new TextBox();
            label2 = new Label();
            cmbRootAlgorithm = new ComboBox();
            btnExportRoot = new Button();
            label3 = new Label();
            txtRootPassword = new TextBox();
            SuspendLayout();
            // 
            // btnCreateRootCertificate
            // 
            btnCreateRootCertificate.Location = new Point(85, 163);
            btnCreateRootCertificate.Name = "btnCreateRootCertificate";
            btnCreateRootCertificate.Size = new Size(268, 57);
            btnCreateRootCertificate.TabIndex = 1;
            btnCreateRootCertificate.Text = "Create Root Certificate";
            btnCreateRootCertificate.UseVisualStyleBackColor = true;
            btnCreateRootCertificate.Click += btnCreateRootCertificate_Click;
            // 
            // CommonName
            // 
            CommonName.AutoSize = true;
            CommonName.Location = new Point(18, 12);
            CommonName.Name = "CommonName";
            CommonName.Size = new Size(117, 20);
            CommonName.TabIndex = 2;
            CommonName.Text = "CommonName :";
            // 
            // txtCommonName
            // 
            txtCommonName.Location = new Point(156, 12);
            txtCommonName.Name = "txtCommonName";
            txtCommonName.Size = new Size(240, 27);
            txtCommonName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 84);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Years :";
            // 
            // txtRootYears
            // 
            txtRootYears.Location = new Point(156, 84);
            txtRootYears.Name = "txtRootYears";
            txtRootYears.Size = new Size(240, 27);
            txtRootYears.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 123);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Algorithm Name :";
            // 
            // cmbRootAlgorithm
            // 
            cmbRootAlgorithm.FormattingEnabled = true;
            cmbRootAlgorithm.Location = new Point(156, 120);
            cmbRootAlgorithm.Name = "cmbRootAlgorithm";
            cmbRootAlgorithm.Size = new Size(240, 28);
            cmbRootAlgorithm.TabIndex = 4;
            // 
            // btnExportRoot
            // 
            btnExportRoot.Location = new Point(85, 237);
            btnExportRoot.Name = "btnExportRoot";
            btnExportRoot.Size = new Size(268, 59);
            btnExportRoot.TabIndex = 5;
            btnExportRoot.Text = "ExportRoot";
            btnExportRoot.UseVisualStyleBackColor = true;
            btnExportRoot.Click += btnExportRoot_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 45);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 2;
            label3.Text = "Root Password :";
            // 
            // txtRootPassword
            // 
            txtRootPassword.Location = new Point(156, 45);
            txtRootPassword.Name = "txtRootPassword";
            txtRootPassword.Size = new Size(240, 27);
            txtRootPassword.TabIndex = 3;
            // 
            // RootCAfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 356);
            Controls.Add(btnExportRoot);
            Controls.Add(cmbRootAlgorithm);
            Controls.Add(txtRootYears);
            Controls.Add(txtRootPassword);
            Controls.Add(txtCommonName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CommonName);
            Controls.Add(btnCreateRootCertificate);
            Name = "RootCAfrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RootCA";
            Load += RootCA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateRootCertificate;
        private Label CommonName;
        private TextBox txtCommonName;
        private Label label1;
        private TextBox txtRootYears;
        private Label label2;
        private ComboBox cmbRootAlgorithm;
        private TextBox txtAlgorithmName;
        private Button btnExportRoot;
        private Label label3;
        private TextBox txtRootPassword;
    }
}