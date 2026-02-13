namespace KI.WinForms
{
    partial class GenerateEndfrm
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
            btnPfx = new Button();
            lblRootPfxPath = new Label();
            txtRootPfxPath = new TextBox();
            btnExportEndEntity = new Button();
            cmbEndEntityAlgorithm = new ComboBox();
            txtIntermediateYears = new TextBox();
            txtIntermediatePassword = new TextBox();
            txtIntermediateCN = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            CommonName = new Label();
            btnGenerateEndEntity = new Button();
            SuspendLayout();
            // 
            // btnPfx
            // 
            btnPfx.Location = new Point(450, 11);
            btnPfx.Name = "btnPfx";
            btnPfx.Size = new Size(97, 29);
            btnPfx.TabIndex = 33;
            btnPfx.Text = "SelectPfx";
            btnPfx.UseVisualStyleBackColor = true;
            btnPfx.Click += btnPfx_Click;
            // 
            // lblRootPfxPath
            // 
            lblRootPfxPath.AutoSize = true;
            lblRootPfxPath.Location = new Point(88, 26);
            lblRootPfxPath.Name = "lblRootPfxPath";
            lblRootPfxPath.Size = new Size(96, 20);
            lblRootPfxPath.TabIndex = 32;
            lblRootPfxPath.Text = "RootPfxPath :";
            // 
            // txtRootPfxPath
            // 
            txtRootPfxPath.Location = new Point(204, 12);
            txtRootPfxPath.Name = "txtRootPfxPath";
            txtRootPfxPath.Size = new Size(240, 27);
            txtRootPfxPath.TabIndex = 31;
            // 
            // btnExportEndEntity
            // 
            btnExportEndEntity.Location = new Point(192, 299);
            btnExportEndEntity.Name = "btnExportEndEntity";
            btnExportEndEntity.Size = new Size(268, 59);
            btnExportEndEntity.TabIndex = 30;
            btnExportEndEntity.Text = "Export End Entity";
            btnExportEndEntity.UseVisualStyleBackColor = true;
            btnExportEndEntity.Click += btnExportEndEntity_Click;
            // 
            // cmbEndEntityAlgorithm
            // 
            cmbEndEntityAlgorithm.FormattingEnabled = true;
            cmbEndEntityAlgorithm.Location = new Point(204, 182);
            cmbEndEntityAlgorithm.Name = "cmbEndEntityAlgorithm";
            cmbEndEntityAlgorithm.Size = new Size(240, 28);
            cmbEndEntityAlgorithm.TabIndex = 29;
            // 
            // txtIntermediateYears
            // 
            txtIntermediateYears.Location = new Point(204, 139);
            txtIntermediateYears.Name = "txtIntermediateYears";
            txtIntermediateYears.Size = new Size(240, 27);
            txtIntermediateYears.TabIndex = 25;
            // 
            // txtIntermediatePassword
            // 
            txtIntermediatePassword.Location = new Point(204, 56);
            txtIntermediatePassword.Name = "txtIntermediatePassword";
            txtIntermediatePassword.Size = new Size(240, 27);
            txtIntermediatePassword.TabIndex = 26;
            // 
            // txtIntermediateCN
            // 
            txtIntermediateCN.Location = new Point(204, 99);
            txtIntermediateCN.Name = "txtIntermediateCN";
            txtIntermediateCN.Size = new Size(240, 27);
            txtIntermediateCN.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 63);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 21;
            label4.Text = "IntermediatePassword :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 182);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 20;
            label2.Text = "Algorithm Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 146);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 23;
            label1.Text = "Years :";
            // 
            // CommonName
            // 
            CommonName.AutoSize = true;
            CommonName.Location = new Point(67, 106);
            CommonName.Name = "CommonName";
            CommonName.Size = new Size(117, 20);
            CommonName.TabIndex = 24;
            CommonName.Text = "CommonName :";
            // 
            // btnGenerateEndEntity
            // 
            btnGenerateEndEntity.Location = new Point(192, 225);
            btnGenerateEndEntity.Name = "btnGenerateEndEntity";
            btnGenerateEndEntity.Size = new Size(268, 57);
            btnGenerateEndEntity.TabIndex = 19;
            btnGenerateEndEntity.Text = "Generate End Entity";
            btnGenerateEndEntity.UseVisualStyleBackColor = true;
            btnGenerateEndEntity.Click += btnGenerateIntermediate_Click;
            // 
            // GenerateEndfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(btnPfx);
            Controls.Add(lblRootPfxPath);
            Controls.Add(txtRootPfxPath);
            Controls.Add(btnExportEndEntity);
            Controls.Add(cmbEndEntityAlgorithm);
            Controls.Add(txtIntermediateYears);
            Controls.Add(txtIntermediatePassword);
            Controls.Add(txtIntermediateCN);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CommonName);
            Controls.Add(btnGenerateEndEntity);
            Name = "GenerateEndfrm";
            Text = "GenerateEndfrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPfx;
        private Label lblRootPfxPath;
        private TextBox txtRootPfxPath;
        private Button btnExportEndEntity;
        private ComboBox cmbEndEntityAlgorithm;
        private TextBox txtIntermediateYears;
        private TextBox txtIntermediatePassword;
        private TextBox txtIntermediateCN;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label CommonName;
        private Button btnGenerateEndEntity;
    }
}