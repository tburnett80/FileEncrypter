namespace FrontEnd
{
    partial class AsymmetricKey
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
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrivKeyType = new System.Windows.Forms.TextBox();
            this.txtPrivTimeStamp = new System.Windows.Forms.TextBox();
            this.txtPrivKeyLen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrivKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrivKeyDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrivKeyName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 397);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key Details";
            // 
            // txtPubKeyType
            // 
            this.txtPubKeyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubKeyType.Location = new System.Drawing.Point(126, 280);
            this.txtPubKeyType.Name = "txtPubKeyType";
            this.txtPubKeyType.ReadOnly = true;
            this.txtPubKeyType.Size = new System.Drawing.Size(315, 27);
            this.txtPubKeyType.TabIndex = 13;
            // 
            // txtPubTimeStamp
            // 
            this.txtPubTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubTimeStamp.Location = new System.Drawing.Point(126, 353);
            this.txtPubTimeStamp.Name = "txtPubTimeStamp";
            this.txtPubTimeStamp.ReadOnly = true;
            this.txtPubTimeStamp.Size = new System.Drawing.Size(315, 27);
            this.txtPubTimeStamp.TabIndex = 12;
            // 
            // txtPubKeyLen
            // 
            this.txtPubKeyLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubKeyLen.Location = new System.Drawing.Point(126, 320);
            this.txtPubKeyLen.Name = "txtPubKeyLen";
            this.txtPubKeyLen.ReadOnly = true;
            this.txtPubKeyLen.Size = new System.Drawing.Size(315, 27);
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
            this.txtPubKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtPubKeyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtPubKeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubKeyName.Location = new System.Drawing.Point(94, 30);
            this.txtPubKeyName.Name = "txtPubKeyName";
            this.txtPubKeyName.Size = new System.Drawing.Size(347, 27);
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
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(12, 405);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(90, 31);
            this.btnSaveKey.TabIndex = 14;
            this.btnSaveKey.Text = "Save";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrivKeyType);
            this.groupBox2.Controls.Add(this.txtPrivTimeStamp);
            this.groupBox2.Controls.Add(this.txtPrivKeyLen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrivKey);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrivKeyDescription);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPrivKeyName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(456, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 396);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Private Key Details";
            // 
            // txtPrivKeyType
            // 
            this.txtPrivKeyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivKeyType.Location = new System.Drawing.Point(126, 280);
            this.txtPrivKeyType.Name = "txtPrivKeyType";
            this.txtPrivKeyType.ReadOnly = true;
            this.txtPrivKeyType.Size = new System.Drawing.Size(315, 27);
            this.txtPrivKeyType.TabIndex = 13;
            // 
            // txtPrivTimeStamp
            // 
            this.txtPrivTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivTimeStamp.Location = new System.Drawing.Point(126, 353);
            this.txtPrivTimeStamp.Name = "txtPrivTimeStamp";
            this.txtPrivTimeStamp.ReadOnly = true;
            this.txtPrivTimeStamp.Size = new System.Drawing.Size(315, 27);
            this.txtPrivTimeStamp.TabIndex = 12;
            // 
            // txtPrivKeyLen
            // 
            this.txtPrivKeyLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivKeyLen.Location = new System.Drawing.Point(126, 320);
            this.txtPrivKeyLen.Name = "txtPrivKeyLen";
            this.txtPrivKeyLen.ReadOnly = true;
            this.txtPrivKeyLen.Size = new System.Drawing.Size(315, 27);
            this.txtPrivKeyLen.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Key Timestamp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Key Length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Key Type";
            // 
            // txtPrivKey
            // 
            this.txtPrivKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivKey.Location = new System.Drawing.Point(19, 176);
            this.txtPrivKey.Multiline = true;
            this.txtPrivKey.Name = "txtPrivKey";
            this.txtPrivKey.ReadOnly = true;
            this.txtPrivKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivKey.Size = new System.Drawing.Size(422, 87);
            this.txtPrivKey.TabIndex = 6;
            this.txtPrivKey.Text = "Generating Key....";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Key Text";
            // 
            // txtPrivKeyDescription
            // 
            this.txtPrivKeyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivKeyDescription.Location = new System.Drawing.Point(18, 90);
            this.txtPrivKeyDescription.MaxLength = 100;
            this.txtPrivKeyDescription.Multiline = true;
            this.txtPrivKeyDescription.Name = "txtPrivKeyDescription";
            this.txtPrivKeyDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivKeyDescription.Size = new System.Drawing.Size(423, 57);
            this.txtPrivKeyDescription.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Key Description";
            // 
            // txtPrivKeyName
            // 
            this.txtPrivKeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivKeyName.Location = new System.Drawing.Point(94, 30);
            this.txtPrivKeyName.Name = "txtPrivKeyName";
            this.txtPrivKeyName.Size = new System.Drawing.Size(347, 27);
            this.txtPrivKeyName.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Key Name";
            // 
            // AsymmetricKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 449);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsymmetricKey";
            this.Text = "New Asymmetric Keys";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txtPubKeyType;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrivKeyType;
        private System.Windows.Forms.TextBox txtPrivTimeStamp;
        private System.Windows.Forms.TextBox txtPrivKeyLen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrivKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrivKeyDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPrivKeyName;
        private System.Windows.Forms.Label label12;
    }
}