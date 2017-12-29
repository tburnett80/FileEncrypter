namespace FrontEnds
{
    partial class SymmertricKey
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAsymmKey = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyType = new System.Windows.Forms.TextBox();
            this.txtTimstamps = new System.Windows.Forms.TextBox();
            this.txtKeyLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAsymmKey);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKeyType);
            this.groupBox1.Controls.Add(this.txtTimstamps);
            this.groupBox1.Controls.Add(this.txtKeyLen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKeyDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKeyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(894, 865);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetric Key Details";
            // 
            // cmbAsymmKey
            // 
            this.cmbAsymmKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsymmKey.FormattingEnabled = true;
            this.cmbAsymmKey.Location = new System.Drawing.Point(265, 314);
            this.cmbAsymmKey.Name = "cmbAsymmKey";
            this.cmbAsymmKey.Size = new System.Drawing.Size(613, 39);
            this.cmbAsymmKey.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Asymmetric Key";
            // 
            // txtKeyType
            // 
            this.txtKeyType.Location = new System.Drawing.Point(252, 652);
            this.txtKeyType.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeyType.Name = "txtKeyType";
            this.txtKeyType.ReadOnly = true;
            this.txtKeyType.Size = new System.Drawing.Size(626, 38);
            this.txtKeyType.TabIndex = 13;
            // 
            // txtTimstamps
            // 
            this.txtTimstamps.Location = new System.Drawing.Point(252, 794);
            this.txtTimstamps.Margin = new System.Windows.Forms.Padding(6);
            this.txtTimstamps.Name = "txtTimstamps";
            this.txtTimstamps.ReadOnly = true;
            this.txtTimstamps.Size = new System.Drawing.Size(626, 38);
            this.txtTimstamps.TabIndex = 12;
            // 
            // txtKeyLen
            // 
            this.txtKeyLen.Location = new System.Drawing.Point(252, 730);
            this.txtKeyLen.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeyLen.Name = "txtKeyLen";
            this.txtKeyLen.ReadOnly = true;
            this.txtKeyLen.Size = new System.Drawing.Size(626, 38);
            this.txtKeyLen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 800);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key Timestamp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 736);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 658);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key Type";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(38, 451);
            this.txtKey.Margin = new System.Windows.Forms.Padding(6);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(840, 165);
            this.txtKey.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key Text";
            // 
            // txtKeyDescription
            // 
            this.txtKeyDescription.Location = new System.Drawing.Point(36, 174);
            this.txtKeyDescription.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeyDescription.MaxLength = 100;
            this.txtKeyDescription.Multiline = true;
            this.txtKeyDescription.Name = "txtKeyDescription";
            this.txtKeyDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyDescription.Size = new System.Drawing.Size(842, 107);
            this.txtKeyDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key Description";
            // 
            // txtKeyName
            // 
            this.txtKeyName.Location = new System.Drawing.Point(188, 58);
            this.txtKeyName.Margin = new System.Windows.Forms.Padding(6);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.Size = new System.Drawing.Size(690, 38);
            this.txtKeyName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Name";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(711, 917);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(167, 51);
            this.btnGen.TabIndex = 17;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(60, 917);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(145, 51);
            this.btnSaveKey.TabIndex = 16;
            this.btnSaveKey.Text = "Save";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            // 
            // SymmertricKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 991);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveKey);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SymmertricKey";
            this.Text = "Symmertric Key";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeyType;
        private System.Windows.Forms.TextBox txtTimstamps;
        private System.Windows.Forms.TextBox txtKeyLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAsymmKey;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnSaveKey;
    }
}