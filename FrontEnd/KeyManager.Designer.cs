namespace FrontEnd
{
    partial class KeyManager
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
            this.lstKeys = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteKey = new System.Windows.Forms.Button();
            this.txtKeyType = new System.Windows.Forms.TextBox();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.txtKeyLen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyName = new System.Windows.Forms.TextBox();
            this.btnNewSymmKey = new System.Windows.Forms.Button();
            this.btnNewAsymmKey = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKeys
            // 
            this.lstKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKeys.FormattingEnabled = true;
            this.lstKeys.ItemHeight = 20;
            this.lstKeys.Location = new System.Drawing.Point(21, 14);
            this.lstKeys.Name = "lstKeys";
            this.lstKeys.Size = new System.Drawing.Size(277, 424);
            this.lstKeys.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteKey);
            this.groupBox1.Controls.Add(this.txtKeyType);
            this.groupBox1.Controls.Add(this.txtTimestamp);
            this.groupBox1.Controls.Add(this.txtKeyLen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKeyDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKeyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(323, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 436);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Details";
            // 
            // btnDeleteKey
            // 
            this.btnDeleteKey.Location = new System.Drawing.Point(18, 389);
            this.btnDeleteKey.Name = "btnDeleteKey";
            this.btnDeleteKey.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteKey.TabIndex = 14;
            this.btnDeleteKey.Text = "Delete";
            this.btnDeleteKey.UseVisualStyleBackColor = true;
            // 
            // txtKeyType
            // 
            this.txtKeyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyType.Location = new System.Drawing.Point(125, 280);
            this.txtKeyType.Name = "txtKeyType";
            this.txtKeyType.ReadOnly = true;
            this.txtKeyType.Size = new System.Drawing.Size(208, 27);
            this.txtKeyType.TabIndex = 13;
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimestamp.Location = new System.Drawing.Point(126, 353);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.ReadOnly = true;
            this.txtTimestamp.Size = new System.Drawing.Size(208, 27);
            this.txtTimestamp.TabIndex = 12;
            // 
            // txtKeyLen
            // 
            this.txtKeyLen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyLen.Location = new System.Drawing.Point(126, 320);
            this.txtKeyLen.Name = "txtKeyLen";
            this.txtKeyLen.ReadOnly = true;
            this.txtKeyLen.Size = new System.Drawing.Size(208, 27);
            this.txtKeyLen.TabIndex = 11;
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
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(19, 176);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey.Size = new System.Drawing.Size(315, 87);
            this.txtKey.TabIndex = 6;
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
            // txtKeyDesc
            // 
            this.txtKeyDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyDesc.Location = new System.Drawing.Point(18, 90);
            this.txtKeyDesc.Multiline = true;
            this.txtKeyDesc.Name = "txtKeyDesc";
            this.txtKeyDesc.ReadOnly = true;
            this.txtKeyDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyDesc.Size = new System.Drawing.Size(315, 57);
            this.txtKeyDesc.TabIndex = 4;
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
            // txtKeyName
            // 
            this.txtKeyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyName.Location = new System.Drawing.Point(94, 30);
            this.txtKeyName.Name = "txtKeyName";
            this.txtKeyName.ReadOnly = true;
            this.txtKeyName.Size = new System.Drawing.Size(239, 27);
            this.txtKeyName.TabIndex = 2;
            // 
            // btnNewSymmKey
            // 
            this.btnNewSymmKey.Location = new System.Drawing.Point(21, 473);
            this.btnNewSymmKey.Name = "btnNewSymmKey";
            this.btnNewSymmKey.Size = new System.Drawing.Size(174, 34);
            this.btnNewSymmKey.TabIndex = 3;
            this.btnNewSymmKey.Text = "New Symmetric Key";
            this.btnNewSymmKey.UseVisualStyleBackColor = true;
            // 
            // btnNewAsymmKey
            // 
            this.btnNewAsymmKey.Location = new System.Drawing.Point(212, 473);
            this.btnNewAsymmKey.Name = "btnNewAsymmKey";
            this.btnNewAsymmKey.Size = new System.Drawing.Size(174, 34);
            this.btnNewAsymmKey.TabIndex = 4;
            this.btnNewAsymmKey.Text = "New Asymmetric Key";
            this.btnNewAsymmKey.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(406, 473);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(109, 34);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import Key";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(541, 473);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 34);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Key";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // KeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 519);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnNewAsymmKey);
            this.Controls.Add(this.btnNewSymmKey);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKeys);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeyManager";
            this.Text = "Key Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeyName;
        private System.Windows.Forms.TextBox txtKeyDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyLen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.TextBox txtKeyType;
        private System.Windows.Forms.Button btnDeleteKey;
        private System.Windows.Forms.Button btnNewSymmKey;
        private System.Windows.Forms.Button btnNewAsymmKey;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
    }
}