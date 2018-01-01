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
<<<<<<< HEAD
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
=======
            this.DEV_lbWelcome = new System.Windows.Forms.Label();
            this.DEV_grbDebug = new System.Windows.Forms.GroupBox();
            this.DEV_btnBugRefresh = new System.Windows.Forms.Button();
            this.DEV_btnBugDetail = new System.Windows.Forms.Button();
            this.DEV_lbBug = new System.Windows.Forms.Label();
            this.DEV_btnMarkFixed = new System.Windows.Forms.Button();
            this.DEV_btnBugSubmit = new System.Windows.Forms.Button();
            this.DEV_lbDebugStatus = new System.Windows.Forms.Label();
            this.DEV_dgvBug = new System.Windows.Forms.DataGridView();
            this.DEV_lbKnownBug = new System.Windows.Forms.Label();
            this.DEV_grbDev = new System.Windows.Forms.GroupBox();
            this.DEV_btnSubmitReq = new System.Windows.Forms.Button();
            this.DEV_lbPatchNotice = new System.Windows.Forms.Label();
            this.DEV_lbPatchList = new System.Windows.Forms.Label();
            this.DEV_lbStatus = new System.Windows.Forms.Label();
            this.DEV_dgvPatchList = new System.Windows.Forms.DataGridView();
            this.DEV_btnReconnect = new System.Windows.Forms.Button();
            this.DEV_btnDownload = new System.Windows.Forms.Button();
            this.DEV_btnInfo = new System.Windows.Forms.Button();
            this.tabPage_Stats = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_ServerManagement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_PlayerManagement = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DEVER_cbPatchType = new System.Windows.Forms.ComboBox();
            this.DEVER_lbPatchType = new System.Windows.Forms.Label();
            this.DEVER_txbName = new System.Windows.Forms.TextBox();
            this.DEVER_lbPatchName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.DEVER_txbSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DEVER_rtxbFullInfo = new System.Windows.Forms.RichTextBox();
            this.DEVER_txbLink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tabPage_Dev.SuspendLayout();
            this.DEV_grbDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvBug)).BeginInit();
            this.DEV_grbDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvPatchList)).BeginInit();
            this.tabPage_Stats.SuspendLayout();
            this.tabPage_ServerManagement.SuspendLayout();
            this.tabPage_PlayerManagement.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Dev);
<<<<<<< HEAD
            this.tabControl.Controls.Add(this.tabPage_ServerManagement);
=======
            this.tabControl.Controls.Add(this.tabPage_Stats);
            this.tabControl.Controls.Add(this.tabPage_ServerManagement);
            this.tabControl.Controls.Add(this.tabPage_PlayerManagement);
            this.tabControl.Controls.Add(this.tabPage_About);
            this.tabControl.Controls.Add(this.tabPage1);
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(691, 519);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_Dev
            // 
<<<<<<< HEAD
            this.tabPage_Dev.Controls.Add(this.DEV_btnReconnect);
            this.tabPage_Dev.Controls.Add(this.DEV_btnInfo);
            this.tabPage_Dev.Controls.Add(this.DEV_btnDownload);
            this.tabPage_Dev.Controls.Add(this.DEV_lbStatus);
            this.tabPage_Dev.Controls.Add(this.DEV_dgvPatchList);
            this.tabPage_Dev.Controls.Add(this.DEV_lbPatchList);
=======
            this.tabPage_Dev.Controls.Add(this.DEV_lbWelcome);
            this.tabPage_Dev.Controls.Add(this.DEV_grbDebug);
            this.tabPage_Dev.Controls.Add(this.DEV_grbDev);
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            this.tabPage_Dev.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dev.Name = "tabPage_Dev";
            this.tabPage_Dev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dev.Size = new System.Drawing.Size(683, 493);
            this.tabPage_Dev.TabIndex = 0;
            this.tabPage_Dev.Text = "Development";
            this.tabPage_Dev.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
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
=======
            // DEV_lbWelcome
            // 
            this.DEV_lbWelcome.Location = new System.Drawing.Point(28, 7);
            this.DEV_lbWelcome.Name = "DEV_lbWelcome";
            this.DEV_lbWelcome.Size = new System.Drawing.Size(614, 29);
            this.DEV_lbWelcome.TabIndex = 9;
            this.DEV_lbWelcome.Text = resources.GetString("DEV_lbWelcome.Text");
            // 
            // DEV_grbDebug
            // 
            this.DEV_grbDebug.Controls.Add(this.DEV_btnBugRefresh);
            this.DEV_grbDebug.Controls.Add(this.DEV_btnBugDetail);
            this.DEV_grbDebug.Controls.Add(this.DEV_lbBug);
            this.DEV_grbDebug.Controls.Add(this.DEV_btnMarkFixed);
            this.DEV_grbDebug.Controls.Add(this.DEV_btnBugSubmit);
            this.DEV_grbDebug.Controls.Add(this.DEV_lbDebugStatus);
            this.DEV_grbDebug.Controls.Add(this.DEV_dgvBug);
            this.DEV_grbDebug.Controls.Add(this.DEV_lbKnownBug);
            this.DEV_grbDebug.Location = new System.Drawing.Point(15, 293);
            this.DEV_grbDebug.Name = "DEV_grbDebug";
            this.DEV_grbDebug.Size = new System.Drawing.Size(652, 194);
            this.DEV_grbDebug.TabIndex = 8;
            this.DEV_grbDebug.TabStop = false;
            this.DEV_grbDebug.Text = "Debug";
            // 
            // DEV_btnBugRefresh
            // 
            this.DEV_btnBugRefresh.Enabled = false;
            this.DEV_btnBugRefresh.Location = new System.Drawing.Point(526, 45);
            this.DEV_btnBugRefresh.Name = "DEV_btnBugRefresh";
            this.DEV_btnBugRefresh.Size = new System.Drawing.Size(105, 23);
            this.DEV_btnBugRefresh.TabIndex = 13;
            this.DEV_btnBugRefresh.Text = "Refresh";
            this.DEV_btnBugRefresh.UseVisualStyleBackColor = true;
            this.DEV_btnBugRefresh.Click += new System.EventHandler(this.DEV_btnBugRefresh_Click);
            // 
            // DEV_btnBugDetail
            // 
            this.DEV_btnBugDetail.Location = new System.Drawing.Point(526, 74);
            this.DEV_btnBugDetail.Name = "DEV_btnBugDetail";
            this.DEV_btnBugDetail.Size = new System.Drawing.Size(105, 23);
            this.DEV_btnBugDetail.TabIndex = 12;
            this.DEV_btnBugDetail.Text = "View detail";
            this.DEV_btnBugDetail.UseVisualStyleBackColor = true;
            this.DEV_btnBugDetail.Click += new System.EventHandler(this.DEV_btnBugDetail_Click);
            // 
            // DEV_lbBug
            // 
            this.DEV_lbBug.Location = new System.Drawing.Point(7, 165);
            this.DEV_lbBug.Name = "DEV_lbBug";
            this.DEV_lbBug.Size = new System.Drawing.Size(649, 23);
            this.DEV_lbBug.TabIndex = 11;
            this.DEV_lbBug.Text = "* Please check the bug carefully before marking as fixed. If you found a bug or a" +
    "ccidentally mark it as fixed, you can submit a new bug.";
            // 
            // DEV_btnMarkFixed
            // 
            this.DEV_btnMarkFixed.Location = new System.Drawing.Point(526, 103);
            this.DEV_btnMarkFixed.Name = "DEV_btnMarkFixed";
            this.DEV_btnMarkFixed.Size = new System.Drawing.Size(105, 23);
            this.DEV_btnMarkFixed.TabIndex = 10;
            this.DEV_btnMarkFixed.Text = "Mark as fixed";
            this.DEV_btnMarkFixed.UseVisualStyleBackColor = true;
            this.DEV_btnMarkFixed.Click += new System.EventHandler(this.DEV_btnMarkFixed_Click);
            // 
            // DEV_btnBugSubmit
            // 
            this.DEV_btnBugSubmit.Location = new System.Drawing.Point(526, 132);
            this.DEV_btnBugSubmit.Name = "DEV_btnBugSubmit";
            this.DEV_btnBugSubmit.Size = new System.Drawing.Size(105, 23);
            this.DEV_btnBugSubmit.TabIndex = 7;
            this.DEV_btnBugSubmit.Text = "Submit a bug";
            this.DEV_btnBugSubmit.UseVisualStyleBackColor = true;
            this.DEV_btnBugSubmit.Click += new System.EventHandler(this.DEV_btnBugSubmit_Click);
            // 
            // DEV_lbDebugStatus
            // 
            this.DEV_lbDebugStatus.AutoSize = true;
            this.DEV_lbDebugStatus.ForeColor = System.Drawing.Color.Green;
            this.DEV_lbDebugStatus.Location = new System.Drawing.Point(454, 21);
            this.DEV_lbDebugStatus.Name = "DEV_lbDebugStatus";
            this.DEV_lbDebugStatus.Size = new System.Drawing.Size(95, 13);
            this.DEV_lbDebugStatus.TabIndex = 9;
            this.DEV_lbDebugStatus.Text = "Debug Status: Idle";
            // 
            // DEV_dgvBug
            // 
            this.DEV_dgvBug.AllowUserToAddRows = false;
            this.DEV_dgvBug.AllowUserToDeleteRows = false;
            this.DEV_dgvBug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DEV_dgvBug.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DEV_dgvBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEV_dgvBug.Location = new System.Drawing.Point(22, 45);
            this.DEV_dgvBug.MultiSelect = false;
            this.DEV_dgvBug.Name = "DEV_dgvBug";
            this.DEV_dgvBug.ReadOnly = true;
            this.DEV_dgvBug.RowHeadersVisible = false;
            this.DEV_dgvBug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DEV_dgvBug.Size = new System.Drawing.Size(498, 112);
            this.DEV_dgvBug.TabIndex = 7;
            // 
            // DEV_lbKnownBug
            // 
            this.DEV_lbKnownBug.AutoSize = true;
            this.DEV_lbKnownBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEV_lbKnownBug.Location = new System.Drawing.Point(19, 19);
            this.DEV_lbKnownBug.Name = "DEV_lbKnownBug";
            this.DEV_lbKnownBug.Size = new System.Drawing.Size(152, 17);
            this.DEV_lbKnownBug.TabIndex = 6;
            this.DEV_lbKnownBug.Text = "Current known bugs";
            // 
            // DEV_grbDev
            // 
            this.DEV_grbDev.Controls.Add(this.DEV_btnSubmitReq);
            this.DEV_grbDev.Controls.Add(this.DEV_lbPatchNotice);
            this.DEV_grbDev.Controls.Add(this.DEV_lbPatchList);
            this.DEV_grbDev.Controls.Add(this.DEV_lbStatus);
            this.DEV_grbDev.Controls.Add(this.DEV_dgvPatchList);
            this.DEV_grbDev.Controls.Add(this.DEV_btnReconnect);
            this.DEV_grbDev.Controls.Add(this.DEV_btnDownload);
            this.DEV_grbDev.Controls.Add(this.DEV_btnInfo);
            this.DEV_grbDev.Location = new System.Drawing.Point(15, 39);
            this.DEV_grbDev.Name = "DEV_grbDev";
            this.DEV_grbDev.Size = new System.Drawing.Size(652, 248);
            this.DEV_grbDev.TabIndex = 7;
            this.DEV_grbDev.TabStop = false;
            this.DEV_grbDev.Text = "Update";
            // 
            // DEV_btnSubmitReq
            // 
            this.DEV_btnSubmitReq.Location = new System.Drawing.Point(526, 161);
            this.DEV_btnSubmitReq.Name = "DEV_btnSubmitReq";
            this.DEV_btnSubmitReq.Size = new System.Drawing.Size(105, 27);
            this.DEV_btnSubmitReq.TabIndex = 7;
            this.DEV_btnSubmitReq.Text = "Submit a request";
            this.DEV_btnSubmitReq.UseVisualStyleBackColor = true;
            this.DEV_btnSubmitReq.Click += new System.EventHandler(this.DEV_btnSubmitReq_Click);
            // 
            // DEV_lbPatchNotice
            // 
            this.DEV_lbPatchNotice.Location = new System.Drawing.Point(11, 209);
            this.DEV_lbPatchNotice.Name = "DEV_lbPatchNotice";
            this.DEV_lbPatchNotice.Size = new System.Drawing.Size(633, 29);
            this.DEV_lbPatchNotice.TabIndex = 6;
            this.DEV_lbPatchNotice.Text = resources.GetString("DEV_lbPatchNotice.Text");
            // 
            // DEV_lbPatchList
            // 
            this.DEV_lbPatchList.AutoSize = true;
            this.DEV_lbPatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEV_lbPatchList.Location = new System.Drawing.Point(19, 20);
            this.DEV_lbPatchList.Name = "DEV_lbPatchList";
            this.DEV_lbPatchList.Size = new System.Drawing.Size(251, 17);
            this.DEV_lbPatchList.TabIndex = 0;
            this.DEV_lbPatchList.Text = "Latest Update && Bug Fix Patches:\r\n";
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            // 
            // DEV_lbStatus
            // 
            this.DEV_lbStatus.AutoSize = true;
            this.DEV_lbStatus.ForeColor = System.Drawing.Color.Green;
<<<<<<< HEAD
            this.DEV_lbStatus.Location = new System.Drawing.Point(385, 15);
            this.DEV_lbStatus.Name = "DEV_lbStatus";
            this.DEV_lbStatus.Size = new System.Drawing.Size(60, 13);
            this.DEV_lbStatus.TabIndex = 2;
            this.DEV_lbStatus.Text = "Status: Idle";
=======
            this.DEV_lbStatus.Location = new System.Drawing.Point(454, 22);
            this.DEV_lbStatus.Name = "DEV_lbStatus";
            this.DEV_lbStatus.Size = new System.Drawing.Size(98, 13);
            this.DEV_lbStatus.TabIndex = 2;
            this.DEV_lbStatus.Text = "Update Status: Idle";
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            // 
            // DEV_dgvPatchList
            // 
            this.DEV_dgvPatchList.AllowUserToAddRows = false;
            this.DEV_dgvPatchList.AllowUserToDeleteRows = false;
            this.DEV_dgvPatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DEV_dgvPatchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DEV_dgvPatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.DEV_dgvPatchList.Location = new System.Drawing.Point(33, 47);
=======
            this.DEV_dgvPatchList.Location = new System.Drawing.Point(22, 50);
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            this.DEV_dgvPatchList.MultiSelect = false;
            this.DEV_dgvPatchList.Name = "DEV_dgvPatchList";
            this.DEV_dgvPatchList.ReadOnly = true;
            this.DEV_dgvPatchList.RowHeadersVisible = false;
            this.DEV_dgvPatchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
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
=======
            this.DEV_dgvPatchList.Size = new System.Drawing.Size(498, 152);
            this.DEV_dgvPatchList.TabIndex = 1;
            // 
            // DEV_btnReconnect
            // 
            this.DEV_btnReconnect.Location = new System.Drawing.Point(526, 61);
            this.DEV_btnReconnect.Name = "DEV_btnReconnect";
            this.DEV_btnReconnect.Size = new System.Drawing.Size(105, 27);
            this.DEV_btnReconnect.TabIndex = 5;
            this.DEV_btnReconnect.Text = "Refresh";
            this.DEV_btnReconnect.UseVisualStyleBackColor = true;
            this.DEV_btnReconnect.Click += new System.EventHandler(this.DEV_btnReconnect_Click);
            // 
            // DEV_btnDownload
            // 
            this.DEV_btnDownload.Location = new System.Drawing.Point(526, 128);
            this.DEV_btnDownload.Name = "DEV_btnDownload";
            this.DEV_btnDownload.Size = new System.Drawing.Size(105, 27);
            this.DEV_btnDownload.TabIndex = 3;
            this.DEV_btnDownload.Text = "Download";
            this.DEV_btnDownload.UseVisualStyleBackColor = true;
            this.DEV_btnDownload.Click += new System.EventHandler(this.DEV_btnDownload_Click);
            // 
            // DEV_btnInfo
            // 
            this.DEV_btnInfo.Location = new System.Drawing.Point(526, 94);
            this.DEV_btnInfo.Name = "DEV_btnInfo";
            this.DEV_btnInfo.Size = new System.Drawing.Size(105, 27);
            this.DEV_btnInfo.TabIndex = 4;
            this.DEV_btnInfo.Text = "View detail";
            this.DEV_btnInfo.UseVisualStyleBackColor = true;
            this.DEV_btnInfo.Click += new System.EventHandler(this.DEV_btnInfo_Click);
            // 
            // tabPage_Stats
            // 
            this.tabPage_Stats.Controls.Add(this.label2);
            this.tabPage_Stats.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Stats.Name = "tabPage_Stats";
            this.tabPage_Stats.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Stats.Size = new System.Drawing.Size(683, 493);
            this.tabPage_Stats.TabIndex = 1;
            this.tabPage_Stats.Text = "Server Statistics";
            this.tabPage_Stats.UseVisualStyleBackColor = true;
            this.tabPage_Stats.Click += new System.EventHandler(this.tabPage_Stats_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "This one is just an idea but it\'s out of my budget. If you really like this tool," +
    " you can fund me to develop it further. ";
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            // 
            // tabPage_ServerManagement
            // 
            this.tabPage_ServerManagement.Controls.Add(this.label1);
            this.tabPage_ServerManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ServerManagement.Name = "tabPage_ServerManagement";
            this.tabPage_ServerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ServerManagement.Size = new System.Drawing.Size(683, 493);
<<<<<<< HEAD
            this.tabPage_ServerManagement.TabIndex = 1;
=======
            this.tabPage_ServerManagement.TabIndex = 2;
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            this.tabPage_ServerManagement.Text = "Server Management";
            this.tabPage_ServerManagement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
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
=======
            this.label1.Location = new System.Drawing.Point(86, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This one is just an idea but it\'s out of my budget. If you really like this tool," +
    " you can fund me to develop it further. ";
            // 
            // tabPage_PlayerManagement
            // 
            this.tabPage_PlayerManagement.Controls.Add(this.label3);
            this.tabPage_PlayerManagement.Location = new System.Drawing.Point(4, 22);
            this.tabPage_PlayerManagement.Name = "tabPage_PlayerManagement";
            this.tabPage_PlayerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PlayerManagement.Size = new System.Drawing.Size(683, 493);
            this.tabPage_PlayerManagement.TabIndex = 3;
            this.tabPage_PlayerManagement.Text = "Player Management";
            this.tabPage_PlayerManagement.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "This one is just an idea but it\'s out of my budget. If you really like this tool," +
    " you can fund me to develop it further. ";
            // 
            // tabPage_About
            // 
            this.tabPage_About.Controls.Add(this.pictureBox1);
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_About.Size = new System.Drawing.Size(683, 493);
            this.tabPage_About.TabIndex = 4;
            this.tabPage_About.Text = "About";
            this.tabPage_About.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Borderland_CSGO_Development.Properties.Resources.konachan_com_188033_bismarck_kancolle_blonde_hair_blue_eyes_kantai_collection_tagme;
            this.pictureBox1.Location = new System.Drawing.Point(1, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DEVER_txbLink);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.DEVER_rtxbFullInfo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DEVER_txbSummary);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DEVER_cbPatchType);
            this.tabPage1.Controls.Add(this.DEVER_lbPatchType);
            this.tabPage1.Controls.Add(this.DEVER_txbName);
            this.tabPage1.Controls.Add(this.DEVER_lbPatchName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(683, 493);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Developer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DEVER_cbPatchType
            // 
            this.DEVER_cbPatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DEVER_cbPatchType.FormattingEnabled = true;
            this.DEVER_cbPatchType.Location = new System.Drawing.Point(161, 57);
            this.DEVER_cbPatchType.Name = "DEVER_cbPatchType";
            this.DEVER_cbPatchType.Size = new System.Drawing.Size(170, 21);
            this.DEVER_cbPatchType.TabIndex = 3;
            // 
            // DEVER_lbPatchType
            // 
            this.DEVER_lbPatchType.AutoSize = true;
            this.DEVER_lbPatchType.Location = new System.Drawing.Point(46, 60);
            this.DEVER_lbPatchType.Name = "DEVER_lbPatchType";
            this.DEVER_lbPatchType.Size = new System.Drawing.Size(65, 13);
            this.DEVER_lbPatchType.TabIndex = 2;
            this.DEVER_lbPatchType.Text = "Patch Type:";
            // 
            // DEVER_txbName
            // 
            this.DEVER_txbName.Location = new System.Drawing.Point(161, 31);
            this.DEVER_txbName.Name = "DEVER_txbName";
            this.DEVER_txbName.Size = new System.Drawing.Size(260, 20);
            this.DEVER_txbName.TabIndex = 1;
            // 
            // DEVER_lbPatchName
            // 
            this.DEVER_lbPatchName.AutoSize = true;
            this.DEVER_lbPatchName.Location = new System.Drawing.Point(46, 34);
            this.DEVER_lbPatchName.Name = "DEVER_lbPatchName";
            this.DEVER_lbPatchName.Size = new System.Drawing.Size(69, 13);
            this.DEVER_lbPatchName.TabIndex = 0;
            this.DEVER_lbPatchName.Text = "Patch Name:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(495, 17);
            this.toolStripStatusLabel1.Text = "Borderland CSGO Development Tool v1.0 - Developed by Noirefield (formerly known a" +
    "s Dias)";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel2.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Patch Date:";
            // 
            // DEVER_txbSummary
            // 
            this.DEVER_txbSummary.Location = new System.Drawing.Point(161, 110);
            this.DEVER_txbSummary.Name = "DEVER_txbSummary";
            this.DEVER_txbSummary.Size = new System.Drawing.Size(488, 20);
            this.DEVER_txbSummary.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Patch Summary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Patch Full Info:";
            // 
            // DEVER_rtxbFullInfo
            // 
            this.DEVER_rtxbFullInfo.Location = new System.Drawing.Point(161, 139);
            this.DEVER_rtxbFullInfo.Name = "DEVER_rtxbFullInfo";
            this.DEVER_rtxbFullInfo.Size = new System.Drawing.Size(488, 210);
            this.DEVER_rtxbFullInfo.TabIndex = 9;
            this.DEVER_rtxbFullInfo.Text = "";
            // 
            // DEVER_txbLink
            // 
            this.DEVER_txbLink.Location = new System.Drawing.Point(161, 355);
            this.DEVER_txbLink.Name = "DEVER_txbLink";
            this.DEVER_txbLink.Size = new System.Drawing.Size(488, 20);
            this.DEVER_txbLink.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Patch Link:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 28, 14, 5, 15, 0);
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(715, 543);
=======
            this.ClientSize = new System.Drawing.Size(715, 560);
            this.Controls.Add(this.statusStrip1);
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
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
<<<<<<< HEAD
            this.tabPage_Dev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvPatchList)).EndInit();
            this.tabPage_ServerManagement.ResumeLayout(false);
            this.tabPage_ServerManagement.PerformLayout();
            this.ResumeLayout(false);
=======
            this.DEV_grbDebug.ResumeLayout(false);
            this.DEV_grbDebug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvBug)).EndInit();
            this.DEV_grbDev.ResumeLayout(false);
            this.DEV_grbDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEV_dgvPatchList)).EndInit();
            this.tabPage_Stats.ResumeLayout(false);
            this.tabPage_Stats.PerformLayout();
            this.tabPage_ServerManagement.ResumeLayout(false);
            this.tabPage_ServerManagement.PerformLayout();
            this.tabPage_PlayerManagement.ResumeLayout(false);
            this.tabPage_PlayerManagement.PerformLayout();
            this.tabPage_About.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936

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
<<<<<<< HEAD
=======
        private System.Windows.Forms.GroupBox DEV_grbDebug;
        private System.Windows.Forms.GroupBox DEV_grbDev;
        private System.Windows.Forms.Label DEV_lbKnownBug;
        private System.Windows.Forms.Button DEV_btnMarkFixed;
        private System.Windows.Forms.Button DEV_btnBugSubmit;
        private System.Windows.Forms.Label DEV_lbDebugStatus;
        private System.Windows.Forms.DataGridView DEV_dgvBug;
        private System.Windows.Forms.Label DEV_lbPatchNotice;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label DEV_lbWelcome;
        private System.Windows.Forms.Button DEV_btnSubmitReq;
        private System.Windows.Forms.Label DEV_lbBug;
        private System.Windows.Forms.TabPage tabPage_PlayerManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage_Stats;
        private System.Windows.Forms.Button DEV_btnBugDetail;
        private System.Windows.Forms.Button DEV_btnBugRefresh;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DEVER_lbPatchType;
        private System.Windows.Forms.TextBox DEVER_txbName;
        private System.Windows.Forms.Label DEVER_lbPatchName;
        private System.Windows.Forms.ComboBox DEVER_cbPatchType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DEVER_rtxbFullInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DEVER_txbSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DEVER_txbLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
>>>>>>> c3c6d0f5fed55107351f6060295d3a8371668936
    }
}

