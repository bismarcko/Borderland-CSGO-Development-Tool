namespace Borderland_CSGO_Development
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Dev = new System.Windows.Forms.TabPage();
            this.DEV_btnInfo = new System.Windows.Forms.Button();
            this.DEV_btnDownload = new System.Windows.Forms.Button();
            this.DEV_lbStatus = new System.Windows.Forms.Label();
            this.DEV_dgvPatchList = new System.Windows.Forms.DataGridView();
            this.DEV_lbPatchList = new System.Windows.Forms.Label();
            this.tabPage_ServerManagement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.DEV_btnReconnect = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_Dev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvPatchList)).BeginInit();
            this.tabPage_ServerManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Dev);
            this.tabControl.Controls.Add(this.tabPage_ServerManagement);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(691, 519);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_Dev
            // 
            this.tabPage_Dev.Controls.Add(this.DEV_btnReconnect);
            this.tabPage_Dev.Controls.Add(this.DEV_btnInfo);
            this.tabPage_Dev.Controls.Add(this.DEV_btnDownload);
            this.tabPage_Dev.Controls.Add(this.DEV_lbStatus);
            this.tabPage_Dev.Controls.Add(this.DEV_dgvPatchList);
            this.tabPage_Dev.Controls.Add(this.DEV_lbPatchList);
            this.tabPage_Dev.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dev.Name = "tabPage_Dev";
            this.tabPage_Dev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dev.Size = new System.Drawing.Size(683, 493);
            this.tabPage_Dev.TabIndex = 0;
            this.tabPage_Dev.Text = "Development";
            this.tabPage_Dev.UseVisualStyleBackColor = true;
            // 
            // DEV_btnInfo
            // 
            this.DEV_btnInfo.Location = new System.Drawing.Point(558, 79);
            this.DEV_btnInfo.Name = "DEV_btnInfo";
            this.DEV_btnInfo.Size = new System.Drawing.Size(105, 38);
            this.DEV_btnInfo.TabIndex = 4;
            this.DEV_btnInfo.Text = "View Detail";
            this.DEV_btnInfo.UseVisualStyleBackColor = true;
            // 
            // DEV_btnDownload
            // 
            this.DEV_btnDownload.Location = new System.Drawing.Point(558, 123);
            this.DEV_btnDownload.Name = "DEV_btnDownload";
            this.DEV_btnDownload.Size = new System.Drawing.Size(105, 38);
            this.DEV_btnDownload.TabIndex = 3;
            this.DEV_btnDownload.Text = "Download";
            this.DEV_btnDownload.UseVisualStyleBackColor = true;
            // 
            // DEV_lbStatus
            // 
            this.DEV_lbStatus.AutoSize = true;
            this.DEV_lbStatus.ForeColor = System.Drawing.Color.Green;
            this.DEV_lbStatus.Location = new System.Drawing.Point(385, 15);
            this.DEV_lbStatus.Name = "DEV_lbStatus";
            this.DEV_lbStatus.Size = new System.Drawing.Size(60, 13);
            this.DEV_lbStatus.TabIndex = 2;
            this.DEV_lbStatus.Text = "Status: Idle";
            // 
            // DEV_dgvPatchList
            // 
            this.DEV_dgvPatchList.AllowUserToAddRows = false;
            this.DEV_dgvPatchList.AllowUserToDeleteRows = false;
            this.DEV_dgvPatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DEV_dgvPatchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DEV_dgvPatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEV_dgvPatchList.Location = new System.Drawing.Point(33, 47);
            this.DEV_dgvPatchList.MultiSelect = false;
            this.DEV_dgvPatchList.Name = "DEV_dgvPatchList";
            this.DEV_dgvPatchList.ReadOnly = true;
            this.DEV_dgvPatchList.RowHeadersVisible = false;
            this.DEV_dgvPatchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DEV_dgvPatchList.Size = new System.Drawing.Size(506, 152);
            this.DEV_dgvPatchList.TabIndex = 1;
            // 
            // DEV_lbPatchList
            // 
            this.DEV_lbPatchList.AutoSize = true;
            this.DEV_lbPatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEV_lbPatchList.Location = new System.Drawing.Point(30, 13);
            this.DEV_lbPatchList.Name = "DEV_lbPatchList";
            this.DEV_lbPatchList.Size = new System.Drawing.Size(251, 17);
            this.DEV_lbPatchList.TabIndex = 0;
            this.DEV_lbPatchList.Text = "Latest Update && Bug Fix Patches:\r\n";
            // 
            // tabPage_ServerManagement
            // 
            this.tabPage_ServerManagement.Controls.Add(this.label1);
            this.tabPage_ServerManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ServerManagement.Name = "tabPage_ServerManagement";
            this.tabPage_ServerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ServerManagement.Size = new System.Drawing.Size(683, 493);
            this.tabPage_ServerManagement.TabIndex = 1;
            this.tabPage_ServerManagement.Text = "Server Management";
            this.tabPage_ServerManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Under Construction. Please come back other time. Thank you!";
            // 
            // DEV_btnReconnect
            // 
            this.DEV_btnReconnect.Location = new System.Drawing.Point(570, 10);
            this.DEV_btnReconnect.Name = "DEV_btnReconnect";
            this.DEV_btnReconnect.Size = new System.Drawing.Size(75, 23);
            this.DEV_btnReconnect.TabIndex = 5;
            this.DEV_btnReconnect.Text = "Reload";
            this.DEV_btnReconnect.UseVisualStyleBackColor = true;
            this.DEV_btnReconnect.Click += new System.EventHandler(this.DEV_btnReconnect_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 543);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borderland CSGO Development";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Dev.ResumeLayout(false);
            this.tabPage_Dev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvPatchList)).EndInit();
            this.tabPage_ServerManagement.ResumeLayout(false);
            this.tabPage_ServerManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Dev;
        private System.Windows.Forms.TabPage tabPage_ServerManagement;
        private System.Windows.Forms.Label DEV_lbPatchList;
        private System.Windows.Forms.Label DEV_lbStatus;
        private System.Windows.Forms.DataGridView DEV_dgvPatchList;
        private System.Windows.Forms.Button DEV_btnDownload;
        private System.Windows.Forms.Button DEV_btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DEV_btnReconnect;
    }
}

