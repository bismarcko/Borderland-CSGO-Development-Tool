using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net;

namespace Borderland_CSGO_Development
{
    delegate void DGVLoading(object Data);
    delegate void SetStatusText(string Text);
    delegate void SetButtonStatus(bool Enabled);
    delegate void SetDownload(string Url);

    public partial class Main : Form
    {
        SaveFileDialog SavePatch;
        string CurrentDownload;

        List<PatchType> PatchTypeList;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Lock Development Patch buttons
            DEV_btnReconnect.Enabled = false;
            DEV_btnDownload.Enabled = false;
            DEV_btnInfo.Enabled = false;
             
            // Load patch lists
            DEV_lbStatus.Text = "Update Status: Connecting...";
            Load_PatchList();

            // Bugs section
            DEV_btnBugDetail.Enabled = false;
            DEV_btnMarkFixed.Enabled = false;
            DEV_btnBugSubmit.Enabled = false;

            // Load bugs
            DEV_lbDebugStatus.Text = "Debug Status: Connecting...";
            Load_BugList();

            // SaveDialog
            SavePatch = new SaveFileDialog();
            SavePatch.Filter = String.Format("{0}|*.*", "Patch Name");
            SavePatch.FilterIndex = 1;

            // Init Dev-er
            PatchTypeList = new List<PatchType>();

            PatchTypeList.Add(new PatchType() { ID = 1, TYPENAME = "Update" });
            PatchTypeList.Add(new PatchType() { ID = 2, TYPENAME = "Bug Fix" });
            PatchTypeList.Add(new PatchType() { ID = 3, TYPENAME = "Update & Bug Fix" });

            DEVER_cbPatchType.DataSource = PatchTypeList;
            DEVER_cbPatchType.DisplayMember = "TYPENAME";
            DEVER_cbPatchType.SelectedIndex = 0;
        }

        void Load_PatchList()
        {
            Thread ReloadPatch = new Thread(() => {
                object NewData = null;
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        NewData = (from P in DB.Patches
                                   join TP in DB.PatchTypes on P.PATCHTYPE equals TP.ID
                                   select new
                                   {
                                       ID = P.ID,
                                       Name = P.PATCHNAME,
                                       Type = TP.TYPENAME,
                                       Date = P.PATCHDATE,
                                       Information = P.PATCHINFO
                                   }).OrderByDescending(P => P.Date).ToList();

                        Reload_PatchList(NewData);
                    }
                    catch
                    {
                        Set_PatchStatus("Update Status: Can't connect to server.");
                        Thread.CurrentThread.Abort();
                    }
                }
                
            });

            ReloadPatch.IsBackground = true;
            ReloadPatch.Start();
        }

        void Load_BugList()
        {
            Thread ReloadBug = new Thread(() => {
                using(BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        object Data = (from B in DB.Bugs
                                       join BT in DB.BugTypes on B.BUGTYPE equals BT.ID
                                       select new
                                       {
                                           ID = B.ID,
                                           Name = B.BUGNAME,
                                           Type = BT.TYPENAME,
                                           Date = B.BUGDATE,
                                           Game_Version = B.GAMEVER,
                                           Information = B.BUGINFO,
                                           Fixed = B.BUGFIXED
                                       }).OrderByDescending(P => P.Date).ToList();

                        Reload_BugList(Data);
                    }
                    catch
                    {
                        Set_DebugStatus("Debug Status: Can't connect to server.");
                        Thread.CurrentThread.Abort();
                    }
                }
            });

            ReloadBug.IsBackground = true;
            ReloadBug.Start();
        }

        void Set_PatchStatus(string Text)
        {
            if(DEV_lbStatus.InvokeRequired)
            {
                SetStatusText This = new SetStatusText(Set_PatchStatus);
                this.Invoke(This, new object[] { Text });
            } else
            {
                DEV_lbStatus.Text = Text;
                
                DEV_btnReconnect.Enabled = true;
            }
        }

        void Set_DebugStatus(string Text)
        {
            if(DEV_lbDebugStatus.InvokeRequired)
            {
                this.Invoke(new SetStatusText(Set_DebugStatus), new object[] { Text });
            } else
            {
                DEV_lbDebugStatus.Text = Text;
                
                DEV_btnBugRefresh.Enabled = true;
            }
        }
        
        void Reload_PatchList(object Data)
        {
            if(DEV_dgvPatchList.InvokeRequired)
            {
                DGVLoading This = new DGVLoading(Reload_PatchList);
                this.Invoke(This, new object[] { Data });
            } else
            {
                DEV_dgvPatchList.DataSource = Data;
                DEV_lbStatus.Text = "Update Status: Loading completed!";

                DEV_btnDownload.Enabled = true;
                DEV_btnInfo.Enabled = true;
                DEV_btnReconnect.Enabled = true;
            }
        }

        void Reload_BugList(object Data)
        {
            if(DEV_dgvBug.InvokeRequired)
            {
                this.Invoke(new DGVLoading(Reload_BugList), new object[] { Data });
            } else
            {
                DEV_dgvBug.DataSource = Data;
                DEV_lbDebugStatus.Text = "Debug Status: Loading completed!";

                DEV_btnBugRefresh.Enabled = true;
                DEV_btnBugDetail.Enabled = true;
                DEV_btnMarkFixed.Enabled = true;
                DEV_btnBugSubmit.Enabled = true;
            }
        }

        private void DEV_btnReconnect_Click(object sender, EventArgs e)
        {
            DEV_lbStatus.Text = "Update Status: Connecting...";

            DEV_btnReconnect.Enabled = false;
            DEV_btnDownload.Enabled = false;
            DEV_btnInfo.Enabled = false;

            Load_PatchList();
        }
        
        private void DEV_btnBugRefresh_Click(object sender, EventArgs e)
        {
            DEV_lbDebugStatus.Text = "Debug Status: Connecting...";

            DEV_btnBugRefresh.Enabled = false;
            DEV_btnBugDetail.Enabled = false;
            DEV_btnMarkFixed.Enabled = false;
            DEV_btnBugSubmit.Enabled = false;

            Load_BugList();
        }

        private void DEV_btnInfo_Click(object sender, EventArgs e)
        {
            if(DEV_dgvPatchList.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a patch first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int? PID = (int)DEV_dgvPatchList.SelectedCells[0].OwningRow.Cells["ID"].Value;

            Thread Th_PatchDetail = new Thread(() => {
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        Patch ThisPatch = DB.Patches.FirstOrDefault(P => P.ID == PID);
                        MessageBox.Show(ThisPatch.PATCHINFO_FULL, ThisPatch.PATCHNAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        PatchButtonOff(false);
                        MessageBox.Show("Can not load patch detail. Please refresh the patch list.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Thread.CurrentThread.Abort();
                    }
                }

            });

            Th_PatchDetail.IsBackground = true;
            Th_PatchDetail.Start();
        }

        private void PatchButtonOff(bool Enabled)
        {
            if(DEV_btnInfo.InvokeRequired)
            {
                this.Invoke(new SetButtonStatus(PatchButtonOff), new object[] { Enabled });
            } else
            {
                DEV_btnReconnect.Enabled = true;
                DEV_btnDownload.Enabled = false;
                DEV_btnInfo.Enabled = false;
            }
        }

        private void DEV_btnBugDetail_Click(object sender, EventArgs e)
        {
            if (DEV_dgvBug.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a bug first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int? PID = (int)DEV_dgvBug.SelectedCells[0].OwningRow.Cells["ID"].Value;

            Thread Th_BugDetal = new Thread(() => {
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        Bug ThisBug = DB.Bugs.FirstOrDefault(P => P.ID == PID);
                        MessageBox.Show(ThisBug.BUGINFO_FULL, ThisBug.BUGNAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        BugButtonOff(false);
                        MessageBox.Show("Can not load bug detail. Please refresh the bug list.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Thread.CurrentThread.Abort();
                    }
                }

            });

            Th_BugDetal.IsBackground = true;
            Th_BugDetal.Start();
        }

        private void BugButtonOff(bool Enabled)
        {
            if (DEV_btnBugDetail.InvokeRequired)
            {
                this.Invoke(new SetButtonStatus(BugButtonOff), new object[] { Enabled });
            }
            else
            {
                DEV_btnBugRefresh.Enabled = true;
                DEV_btnBugDetail.Enabled = false;
                DEV_btnMarkFixed.Enabled = false;
                DEV_btnBugSubmit.Enabled = false;
            }
        }

        private void DEV_btnMarkFixed_Click(object sender, EventArgs e)
        {
            if (DEV_dgvBug.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a bug first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int? PID = (int)DEV_dgvBug.SelectedCells[0].OwningRow.Cells["ID"].Value;

            Thread Th_BugFix = new Thread(() => {
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        Bug ThisBug = DB.Bugs.FirstOrDefault(P => P.ID == PID);
                        ThisBug.BUGFIXED = true;
                        DB.SubmitChanges();

                        MessageBox.Show("Selected bug has been marked as fixed.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        BugButtonOff(false);
                        MessageBox.Show("Can not mark this bug. Please refresh the bug list.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Thread.CurrentThread.Abort();
                    }
                }

            });

            Th_BugFix.IsBackground = true;
            Th_BugFix.Start();
        }

        private void DEV_btnDownload_Click(object sender, EventArgs e)
        {
            if (DEV_dgvPatchList.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Please select a patch first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            int? PID = (int)DEV_dgvPatchList.SelectedCells[0].OwningRow.Cells["ID"].Value;
            
            Thread LinkLoad = new Thread(() => {
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        Patch ThisPatch = DB.Patches.FirstOrDefault(P => P.ID == PID);
                        Download_Check(ThisPatch.LINK);
                    }
                    catch
                    {
                        Set_PatchStatus("Update Status: Can't get the patch link.");
                        Thread.CurrentThread.Abort();
                    }
                }

                Thread.CurrentThread.Abort();
            });

            LinkLoad.IsBackground = true;
            LinkLoad.Start();
        }

        private void Download_Check(string Url)
        {
            Regex Pattern = new Regex(@".*\/(.*)$");
            MatchCollection ThisMatch = Pattern.Matches(Url);

            SavePatch.FileName = ThisMatch[0].Groups[1].Value;
            CurrentDownload = Url;

            this.Invoke((MethodInvoker)delegate
            {
                if(SavePatch.ShowDialog() == DialogResult.OK)
                {
                    Thread Downshit = new Thread(() =>
                    {
                        Set_PatchStatus("Update Status: Downloading patch...");
                        
                        WebClient Download = new WebClient();
                        
                        Download.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressHandler);
                        Download.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted_Handler);
                        Download.DownloadFileAsync(new Uri("http://" + Url), SavePatch.FileName);
                        
                        Thread.CurrentThread.Abort();

                    });

                    Downshit.IsBackground = true;
                    Downshit.Start();
                }
            });
        }

        void DownloadProgressHandler(object sender, DownloadProgressChangedEventArgs E)
        {
            this.Invoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(E.BytesReceived.ToString());
                double totalBytes = double.Parse(E.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;

                toolStripStatusLabel2.Text = String.Format("{0:00}%", percentage);
                toolStripProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        void DownloadCompleted_Handler(object sender, AsyncCompletedEventArgs E)
        {
            this.BeginInvoke((MethodInvoker)delegate
           {
               toolStripProgressBar1.Value = 100;
               MessageBox.Show("Download completed. Please check!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

               Set_PatchStatus("Update Status: Downloading completed!");
           });
        }

        private void DEV_btnSubmitReq_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I guess we will just discuss using Steam :)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DEV_btnBugSubmit_Click(object sender, EventArgs e)
        {
            BugSubmit NewForm = new BugSubmit();
            NewForm.ShowDialog();
        }

        private void tabPage_Stats_Click(object sender, EventArgs e)
        {
            /*
            MySqlConnection Con = new MySqlConnection(MySQLDB.ConString);

            Con.Open();

            string Query = "SELECT COUNT(*) FROM globaloffensive";
            MySqlCommand Command = new MySqlCommand(Query, Con);

            var RetData = Command.ExecuteScalar();
            MessageBox.Show(RetData.ToString());
            Con.Clone();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bismarck_Night_Attack);
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patch NewPatch = new Patch();

            NewPatch.PATCHNAME = DEVER_txbName.Text;
            NewPatch.PATCHTYPE = (DEVER_cbPatchType.SelectedValue as PatchType).ID;
            NewPatch.PATCHDATE = dateTimePicker1.Value;
            NewPatch.PATCHINFO = DEVER_txbSummary.Text;
            NewPatch.PATCHINFO_FULL = DEVER_rtxbFullInfo.Text;
            NewPatch.LINK = DEVER_txbLink.Text;

            Thread InsertThread = new Thread(() =>
            {
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    DB.Patches.InsertOnSubmit(NewPatch);
                    DB.SubmitChanges();
                }

                MessageBox.Show("Succesfully posted!");
            }) { IsBackground = true };

            InsertThread.Start();
        }
    }
}
