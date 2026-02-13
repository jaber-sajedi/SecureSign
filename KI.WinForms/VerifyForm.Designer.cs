namespace KI.WinForms
{
    partial class VerifyForm
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
            btnoriginalFilePath = new Button();
            lblOriginalFilePath = new Label();
            btnSignFile = new Button();
            lblSignFile = new Label();
            btnVerify = new Button();
            lblVerifyState = new Label();
            SuspendLayout();
            // 
            // btnoriginalFilePath
            // 
            btnoriginalFilePath.Location = new Point(12, 28);
            btnoriginalFilePath.Name = "btnoriginalFilePath";
            btnoriginalFilePath.Size = new Size(94, 29);
            btnoriginalFilePath.TabIndex = 0;
            btnoriginalFilePath.Text = "Original File Path";
            btnoriginalFilePath.UseVisualStyleBackColor = true;
            btnoriginalFilePath.Click += btnoriginalFilePath_Click;
            // 
            // lblOriginalFilePath
            // 
            lblOriginalFilePath.AutoSize = true;
            lblOriginalFilePath.Location = new Point(112, 32);
            lblOriginalFilePath.Name = "lblOriginalFilePath";
            lblOriginalFilePath.Size = new Size(104, 20);
            lblOriginalFilePath.TabIndex = 1;
            lblOriginalFilePath.Text = "Original State ";
            // 
            // btnSignFile
            // 
            btnSignFile.Location = new Point(12, 74);
            btnSignFile.Name = "btnSignFile";
            btnSignFile.Size = new Size(94, 29);
            btnSignFile.TabIndex = 0;
            btnSignFile.Text = "Sign File";
            btnSignFile.UseVisualStyleBackColor = true;
            btnSignFile.Click += btnSignFile_Click;
            // 
            // lblSignFile
            // 
            lblSignFile.AutoSize = true;
            lblSignFile.Location = new Point(112, 78);
            lblSignFile.Name = "lblSignFile";
            lblSignFile.Size = new Size(76, 20);
            lblSignFile.TabIndex = 1;
            lblSignFile.Text = "Sign State";
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(12, 121);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(94, 29);
            btnVerify.TabIndex = 2;
            btnVerify.Text = "Verify ";
            btnVerify.UseVisualStyleBackColor = true;
            btnVerify.Click += btnVerify_Click;
            // 
            // lblVerifyState
            // 
            lblVerifyState.AutoSize = true;
            lblVerifyState.Location = new Point(112, 125);
            lblVerifyState.Name = "lblVerifyState";
            lblVerifyState.Size = new Size(84, 20);
            lblVerifyState.TabIndex = 3;
            lblVerifyState.Text = "Verify State";
            // 
            // VerifyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 344);
            Controls.Add(lblVerifyState);
            Controls.Add(btnVerify);
            Controls.Add(lblSignFile);
            Controls.Add(lblOriginalFilePath);
            Controls.Add(btnSignFile);
            Controls.Add(btnoriginalFilePath);
            Name = "VerifyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnoriginalFilePath;
        private Label lblOriginalFilePath;
        private Button btnSignFile;
        private Label lblSignFile;
        private Button btnVerify;
        private Label lblVerifyState;
    }
}