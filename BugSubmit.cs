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
    delegate void SubmitBugNow(BorderlandDataContext DB);
    public partial class BugSubmit : Form
    {
        List<BugType> NewList = new List<BugType>();
    

        public BugSubmit()
        {
            InitializeComponent();
        }

        private void BugSubmit_Load(object sender, EventArgs e)
        {
            // Add data
            NewList.Add(new BugType() { ID = 1, TYPENAME = "Normal" });
            NewList.Add(new BugType() { ID = 2, TYPENAME = "Critical" });
            NewList.Add(new BugType() { ID = 3, TYPENAME = "Optional" });

            // DataSource
            cBBugType.DataSource = NewList;
            cBBugType.DisplayMember = "TYPENAME";
            cBBugType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbBugName.Text == String.Empty || txbGameVer.Text == String.Empty || rtxbBugInfo_Full.Text == String.Empty || txbBugInfo.Text == String.Empty)
            {
                MessageBox.Show("You must fill in all data to submit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Thread SubmitThread = new Thread(() =>
            {
                try
                {
                    using (BorderlandDataContext DB = new BorderlandDataContext())
                    {
                        this.Invoke((MethodInvoker) delegate
                        {
                            Bug NewBug = new Bug();

                            NewBug.BUGNAME = txbBugName.Text;
                            NewBug.BUGINFO = txbBugInfo.Text;
                            NewBug.BUGDATE = DateTime.Now;
                            NewBug.BUGTYPE = (cBBugType.SelectedValue as BugType).ID;
                            NewBug.GAMEVER = txbGameVer.Text;
                            NewBug.BUGINFO_FULL = rtxbBugInfo_Full.Text;
                            NewBug.BUGFIXED = false;

                            DB.Bugs.InsertOnSubmit(NewBug);
                            DB.SubmitChanges();

                            if(MessageBox.Show("Your bug report has been submitted. Please refresh the bug list.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                this.Close();
                            }
                            
                        });
                    }
                }
                catch
                {
                    MessageBox.Show("Can not submit due to some problems. Please check your connection and try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                finally
                {
                    Thread.CurrentThread.Abort();
                }
            });

            SubmitThread.IsBackground = true;
            SubmitThread.Start();
        }
    }
}
