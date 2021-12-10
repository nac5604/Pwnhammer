using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Management;
using System.Security.Principal;
using PwnHammer;
using System.Runtime.InteropServices;

namespace PwnHammer
{
    // the j
    public partial class MainForm : Form
    {
        #region Global Variables

        int defaultPort = 7777;
        bool isRunAsAdmin = ProcessTools.IsRunAsAdmin();

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Icon = PwnHammer.Properties.Resources.Pwnhammer;
            this.Text = String.Format("{0}: {1} | by {2}", Application.ProductName, Application.ProductVersion, Application.CompanyName);
        }

        private void Run_Checks_Button_Click(object sender, EventArgs e)
        {
            PopulateConflictingEntriesList(procList);
        }
        private void Open_Terraria_Server_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\steamapps\common\Terraria\TerrariaServer.exe");
        }

        private void Kill_Conflicting_Programs_Button_Click(object sender, EventArgs e)
        {
            KillConflictingPrograms(procList);
        }

        private void Open_Services_Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"services.msc");
        }

        #region Functions
        public void ConvertToNetstatEntry(string input, DataGridView dgv)
        {
            string[] parts = (Regex.Replace(input, " {2,}", ",", RegexOptions.Multiline).Split(',')).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            dgv.Rows.Add(parts[0],
                         parts[1].Split(':')[0],
                         parts[1].Split(':')[1],
                         parts[2].Split(':')[0],
                         parts[2].Split(':')[1],
                         parts[3],
                         parts[4],
                         Process.GetProcessById(int.Parse(parts[4])).ProcessName
                         );
        }

        public void PopulateConflictingEntriesList(DataGridView dgv)
        {
            System.Diagnostics.ProcessStartInfo process =
            new System.Diagnostics.ProcessStartInfo("cmd", String.Format("/c netstat -a -o -n | findstr :{0}", defaultPort.ToString()));

            process.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.UseShellExecute = false;
            process.CreateNoWindow = true;
            process.RedirectStandardOutput = true;
            process.RedirectStandardInput = true;

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = process;
            p.Start();

            string[] results = (p.StandardOutput.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None)).Where(x => !string.IsNullOrEmpty(x)).ToArray();

            dgv.Rows.Clear();
            foreach (string s in results)
            {
                ConvertToNetstatEntry(s.Replace(Environment.NewLine, String.Empty), dgv);
            }
        }
        public Entry DGVRowToNetstatEntry(DataGridViewRow dgvr)
        {
            Entry entry = new Entry();

            entry.ConnectionType = dgvr.Cells[0].Value.ToString();
            entry.IP = dgvr.Cells[1].Value.ToString();
            entry.Port = dgvr.Cells[2].Value.ToString();
            entry.DestinationIP = dgvr.Cells[3].Value.ToString();
            entry.DestinationPort = dgvr.Cells[4].Value.ToString();
            entry.ConnectionStatus = dgvr.Cells[5].Value.ToString();
            entry.PID = dgvr.Cells[6].Value.ToString();
            entry.ProcessName = dgvr.Cells[7].Value.ToString();

            return entry;
        }
        public void KillConflictingPrograms(DataGridView dgv)
        {
            List<Entry> procsKilled = new List<Entry>();

            if (!isRunAsAdmin)
            {
                AdminDialog ad = new AdminDialog();
                ad.ShowDialog();
            }
            else
            {

                if (dgv.Rows != null)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[7].Value.ToString() != "TerrariaServer" && (row.Cells[7].Value.ToString() != null))
                        {
                            ProcessTools.KillProcessAndChildren(int.Parse(row.Cells[6].Value.ToString()));
                            ProcessTools.DisableService(int.Parse(row.Cells[6].Value.ToString()), row.Cells[7].Value.ToString());
                            procsKilled.Add(DGVRowToNetstatEntry(row));

                            //dgv.Update();
                            //dgv.Refresh();
                            PopulateConflictingEntriesList(dgv);
                        }

                    }

                    KilledProcessesDialog kpd = new KilledProcessesDialog(procsKilled);
                    kpd.Show();
                }
            }
        }
        #endregion

    }
}
