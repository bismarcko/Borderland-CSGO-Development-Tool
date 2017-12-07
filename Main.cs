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

namespace Borderland_CSGO_Development
{
    delegate void DGVLoading(object Data);
    delegate void SetStatusText(string Text);

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DEV_btnReconnect.Enabled = false;
            DEV_btnDownload.Enabled = false;
            DEV_btnInfo.Enabled = false;

            DEV_lbStatus.Text = "Status: Connecting...";
            Load_PatchList();
        }

        void Load_PatchList()
        {
            Thread ReloadThread = new Thread(() => {
                object NewData = null;
                using (BorderlandDataContext DB = new BorderlandDataContext())
                {
                    try
                    {
                        NewData = (from P in DB.Patches
                                   join TP in DB.PatchTypes on P.PATCHTYPE equals TP.ID
                                   select new
                                   {
                                       PatchID = P.ID,
                                       Patch_Name = P.PATCHNAME,
                                       Patch_Type = TP.TYPENAME,
                                       Patch_Date = P.PATCHDATE,
                                       Patch_Info = P.PATCHINFO
                                   }).OrderByDescending(P => P.Patch_Date).ToList();

                        Reload_PatchList(NewData);
                    }
                    catch
                    {
                        NewStatusText("Status: Can't connect to server.");
                        Thread.CurrentThread.Abort();
                    }
                }
                
            });

            ReloadThread.IsBackground = true;
            ReloadThread.Start();
        }

        void NewStatusText(string Text)
        {
            if(DEV_lbStatus.InvokeRequired)
            {
                SetStatusText This = new SetStatusText(NewStatusText);
                this.Invoke(This, new object[] { Text });
            } else
            {
                DEV_lbStatus.Text = Text;

                DEV_btnReconnect.Visible = true;
                DEV_btnReconnect.Enabled = true;

                MessageBox.Show("It seems i can not to the database server. Please check your internet connection or contact the server manager.", "Sadness");
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
                DEV_lbStatus.Text = "Status: Loading completed!";

                DEV_btnDownload.Enabled = true;
                DEV_btnInfo.Enabled = true;
                DEV_btnReconnect.Enabled = true;
            }
           
        }

        private void DEV_btnReconnect_Click(object sender, EventArgs e)
        {
            DEV_lbStatus.Text = "Status: Connecting...";

            DEV_btnReconnect.Enabled = false;
            Load_PatchList();
        }
    }
}
