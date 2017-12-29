namespace FrontEnd
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
            this.txtPubKeyType = new System.Windows.Forms.TextBox();
            this.txtPubTimeStamp = new System.Windows.Forms.TextBox();
            this.txtPubKeyLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPubKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPubKeyDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPubKeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPubKeyType);
            this.groupBox1.Controls.Add(this.txtPubTimeStamp);
            this.groupBox1.Controls.Add(this.txtPubKeyLen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPubKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPubKeyDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPubKeyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 397);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key Details";
            // 
            // txtPubKeyType
            // 
            this.txtPubKeyType.Location = new System.Drawing.Point(126, 280);
            this.txtPubKeyType.Name = "txtPubKeyType";
            this.txtPubKeyType.ReadOnly = true;
            this.txtPubKeyType.Size = new System.Drawing.Size(315, 22);
            this.txtPubKeyType.TabIndex = 13;
            // 
            // txtPubTimeStamp
            // 
            this.txtPubTimeStamp.Location = new System.Drawing.Point(126, 353);
            this.txtPubTimeStamp.Name = "txtPubTimeStamp";
            this.txtPubTimeStamp.ReadOnly = true;
            this.txtPubTimeStamp.Size = new System.Drawing.Size(315, 22);
            this.txtPubTimeStamp.TabIndex = 12;
            // 
            // txtPubKeyLen
            // 
            this.txtPubKeyLen.Location = new System.Drawing.Point(126, 320);
            this.txtPubKeyLen.Name = "txtPubKeyLen";
            this.txtPubKeyLen.ReadOnly = true;
            this.txtPubKeyLen.Size = new System.Drawing.Size(315, 22);
            this.txtPubKeyLen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Key Timestamp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key Type";
            // 
            // txtPubKey
            // 
            this.txtPubKey.Location = new System.Drawing.Point(19, 176);
            this.txtPubKey.Multiline = true;
            this.txtPubKey.Name = "txtPubKey";
            this.txtPubKey.ReadOnly = true;
            this.txtPubKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPubKey.Size = new System.Drawing.Size(422, 87);
            this.txtPubKey.TabIndex = 6;
            this.txtPubKey.Text = "Generating Key....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Key Text";
            // 
            // txtPubKeyDescription
            // 
            this.txtPubKeyDescription.Location = new System.Drawing.Point(18, 90);
            this.txtPubKeyDescription.MaxLength = 100;
            this.txtPubKeyDescription.Multiline = true;
            this.txtPubKeyDescription.Name = "txtPubKeyDescription";
            this.txtPubKeyDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPubKeyDescription.Size = new System.Drawing.Size(423, 57);
            this.txtPubKeyDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key Description";
            // 
            // txtPubKeyName
            // 
            this.txtPubKeyName.Location = new System.Drawing.Point(94, 30);
            this.txtPubKeyName.Name = "txtPubKeyName";
            this.txtPubKeyName.Size = new System.Drawing.Size(347, 22);
            this.txtPubKeyName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Name";
            // 
            // SymmertricKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 424);
            this.Controls.Add(this.groupBox1);
            this.Name = "SymmertricKey";
            this.Text = "SymmertricKey";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPubKeyType;
        private System.Windows.Forms.TextBox txtPubTimeStamp;
        private System.Windows.Forms.TextBox txtPubKeyLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPubKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPubKeyDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPubKeyName;
        private System.Windows.Forms.Label label1;
    }
}