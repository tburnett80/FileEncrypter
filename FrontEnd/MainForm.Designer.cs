namespace FrontEnd
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
            this.btnGen = new System.Windows.Forms.Button();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.btnSymAction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAsym = new System.Windows.Forms.ComboBox();
            this.cmbSym = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.txtInFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(655, 330);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(143, 36);
            this.btnGen.TabIndex = 9;
            this.btnGen.Text = "Manage Keys";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(143, 30);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(78, 21);
            this.rbDecrypt.TabIndex = 7;
            this.rbDecrypt.Text = "Decrypt";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(227, 30);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(77, 21);
            this.rbEncrypt.TabIndex = 6;
            this.rbEncrypt.Text = "Encrypt";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnSymAction
            // 
            this.btnSymAction.Location = new System.Drawing.Point(24, 330);
            this.btnSymAction.Name = "btnSymAction";
            this.btnSymAction.Size = new System.Drawing.Size(93, 36);
            this.btnSymAction.TabIndex = 5;
            this.btnSymAction.Text = "Encrypt";
            this.btnSymAction.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAsym);
            this.groupBox2.Controls.Add(this.cmbSym);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbEncrypt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbDecrypt);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption Details";
            // 
            // cmbAsym
            // 
            this.cmbAsym.FormattingEnabled = true;
            this.cmbAsym.Location = new System.Drawing.Point(7, 116);
            this.cmbAsym.Name = "cmbAsym";
            this.cmbAsym.Size = new System.Drawing.Size(779, 24);
            this.cmbAsym.TabIndex = 10;
            // 
            // cmbSym
            // 
            this.cmbSym.FormattingEnabled = true;
            this.cmbSym.Location = new System.Drawing.Point(7, 57);
            this.cmbSym.Name = "cmbSym";
            this.cmbSym.Size = new System.Drawing.Size(777, 24);
            this.cmbSym.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asymmetric Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Symmetric Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutFile);
            this.groupBox1.Controls.Add(this.txtInFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // txtOutFile
            // 
            this.txtOutFile.Location = new System.Drawing.Point(6, 95);
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(778, 22);
            this.txtOutFile.TabIndex = 3;
            // 
            // txtInFile
            // 
            this.txtInFile.Location = new System.Drawing.Point(6, 38);
            this.txtInFile.Name = "txtInFile";
            this.txtInFile.Size = new System.Drawing.Size(778, 22);
            this.txtInFile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "File input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "File output";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 373);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSymAction);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "File Encryptor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.TextBox txtInFile;
        private System.Windows.Forms.RadioButton rbDecrypt;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.Button btnSymAction;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSym;
        private System.Windows.Forms.ComboBox cmbAsym;
    }
}

