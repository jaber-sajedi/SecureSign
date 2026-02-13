namespace KI.WinForms
{
    partial class SignForm
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
            btnSelectFile = new Button();
            lblFileStatus = new Label();
            lblSignFile = new Label();
            btnSignFile = new Button();
            cmbRootAlgorithm = new ComboBox();
            label2 = new Label();
            btnSelectFileForSign = new Button();
            lblFileForSignStatus = new Label();
            btnSelectCert = new Button();
            lblCertStatus = new Label();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 20);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(118, 29);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Private Key File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // lblFileStatus
            // 
            lblFileStatus.AutoSize = true;
            lblFileStatus.Location = new Point(139, 27);
            lblFileStatus.Name = "lblFileStatus";
            lblFileStatus.Size = new Size(50, 20);
            lblFileStatus.TabIndex = 1;
            lblFileStatus.Text = "label1";
            // 
            // lblSignFile
            // 
            lblSignFile.AutoSize = true;
            lblSignFile.Location = new Point(130, 186);
            lblSignFile.Name = "lblSignFile";
            lblSignFile.Size = new Size(50, 20);
            lblSignFile.TabIndex = 1;
            lblSignFile.Text = "label1";
            // 
            // btnSignFile
            // 
            btnSignFile.Location = new Point(3, 179);
            btnSignFile.Name = "btnSignFile";
            btnSignFile.Size = new Size(118, 29);
            btnSignFile.TabIndex = 2;
            btnSignFile.Text = " Sign File";
            btnSignFile.UseVisualStyleBackColor = true;
            btnSignFile.Click += btnSignFile_Click;
            // 
            // cmbRootAlgorithm
            // 
            cmbRootAlgorithm.FormattingEnabled = true;
            cmbRootAlgorithm.Location = new Point(136, 138);
            cmbRootAlgorithm.Name = "cmbRootAlgorithm";
            cmbRootAlgorithm.Size = new Size(250, 28);
            cmbRootAlgorithm.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 138);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Algorithm Name :";
            // 
            // btnSelectFileForSign
            // 
            btnSelectFileForSign.Location = new Point(12, 90);
            btnSelectFileForSign.Name = "btnSelectFileForSign";
            btnSelectFileForSign.Size = new Size(118, 29);
            btnSelectFileForSign.TabIndex = 7;
            btnSelectFileForSign.Text = "Select File For Sign";
            btnSelectFileForSign.UseVisualStyleBackColor = true;
            btnSelectFileForSign.Click += btnSelectFileForSign_Click;
            // 
            // lblFileForSignStatus
            // 
            lblFileForSignStatus.AutoSize = true;
            lblFileForSignStatus.Location = new Point(139, 94);
            lblFileForSignStatus.Name = "lblFileForSignStatus";
            lblFileForSignStatus.Size = new Size(50, 20);
            lblFileForSignStatus.TabIndex = 8;
            lblFileForSignStatus.Text = "label3";
            // 
            // btnSelectCert
            // 
            btnSelectCert.Location = new Point(12, 55);
            btnSelectCert.Name = "btnSelectCert";
            btnSelectCert.Size = new Size(118, 29);
            btnSelectCert.TabIndex = 9;
            btnSelectCert.Text = "Select Cert";
            btnSelectCert.UseVisualStyleBackColor = true;
            btnSelectCert.Click += btnSelectCert_Click;
            // 
            // lblCertStatus
            // 
            lblCertStatus.AutoSize = true;
            lblCertStatus.Location = new Point(139, 59);
            lblCertStatus.Name = "lblCertStatus";
            lblCertStatus.Size = new Size(50, 20);
            lblCertStatus.TabIndex = 10;
            lblCertStatus.Text = "label3";
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 383);
            Controls.Add(lblCertStatus);
            Controls.Add(btnSelectCert);
            Controls.Add(lblFileForSignStatus);
            Controls.Add(btnSelectFileForSign);
            Controls.Add(cmbRootAlgorithm);
            Controls.Add(label2);
            Controls.Add(btnSignFile);
            Controls.Add(lblSignFile);
            Controls.Add(lblFileStatus);
            Controls.Add(btnSelectFile);
            Name = "SignForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignForm";
            Load += SignForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label lblFileStatus;
 
        private Label lblSignFile;
        private Button btnSignFile;
        private ComboBox cmbRootAlgorithm;
        private Label label2;
        private Button btnSelectFileForSign;
        private Label lblFileForSignStatus;
        private Button btnSelectCert;
        private Label lblCertStatus;
    }
}