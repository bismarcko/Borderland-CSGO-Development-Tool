namespace Borderland_CSGO_Development
{
    partial class BugSubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugSubmit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBugName = new System.Windows.Forms.TextBox();
            this.cBBugType = new System.Windows.Forms.ComboBox();
            this.txbGameVer = new System.Windows.Forms.TextBox();
            this.txbBugInfo = new System.Windows.Forms.TextBox();
            this.rtxbBugInfo_Full = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bug type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bug summary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(125, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "How to perform bug:";
            // 
            // txbBugName
            // 
            this.txbBugName.Location = new System.Drawing.Point(129, 10);
            this.txbBugName.Name = "txbBugName";
            this.txbBugName.Size = new System.Drawing.Size(267, 20);
            this.txbBugName.TabIndex = 5;
            // 
            // cBBugType
            // 
            this.cBBugType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBBugType.FormattingEnabled = true;
            this.cBBugType.Location = new System.Drawing.Point(129, 62);
            this.cBBugType.Name = "cBBugType";
            this.cBBugType.Size = new System.Drawing.Size(179, 21);
            this.cBBugType.TabIndex = 6;
            // 
            // txbGameVer
            // 
            this.txbGameVer.Location = new System.Drawing.Point(128, 89);
            this.txbGameVer.Name = "txbGameVer";
            this.txbGameVer.Size = new System.Drawing.Size(180, 20);
            this.txbGameVer.TabIndex = 7;
            // 
            // txbBugInfo
            // 
            this.txbBugInfo.Location = new System.Drawing.Point(129, 36);
            this.txbBugInfo.Name = "txbBugInfo";
            this.txbBugInfo.Size = new System.Drawing.Size(267, 20);
            this.txbBugInfo.TabIndex = 8;
            // 
            // rtxbBugInfo_Full
            // 
            this.rtxbBugInfo_Full.Location = new System.Drawing.Point(16, 136);
            this.rtxbBugInfo_Full.Name = "rtxbBugInfo_Full";
            this.rtxbBugInfo_Full.Size = new System.Drawing.Size(380, 158);
            this.rtxbBugInfo_Full.TabIndex = 9;
            this.rtxbBugInfo_Full.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BugSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxbBugInfo_Full);
            this.Controls.Add(this.txbBugInfo);
            this.Controls.Add(this.txbGameVer);
            this.Controls.Add(this.cBBugType);
            this.Controls.Add(this.txbBugName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugSubmit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit a bug";
            this.Load += new System.EventHandler(this.BugSubmit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbBugName;
        private System.Windows.Forms.ComboBox cBBugType;
        private System.Windows.Forms.TextBox txbGameVer;
        private System.Windows.Forms.TextBox txbBugInfo;
        private System.Windows.Forms.RichTextBox rtxbBugInfo_Full;
        private System.Windows.Forms.Button button1;
    }
}