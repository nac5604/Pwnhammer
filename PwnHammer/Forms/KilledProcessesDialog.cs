using PwnHammer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwnHammer
{
    public partial class KilledProcessesDialog : Form
    {
        List<Entry> killedProcs;
        int killedProcsAmount;

        public KilledProcessesDialog(List<Entry> entries)
        {
            InitializeComponent();
            this.killedProcs = entries;
            this.killedProcsAmount = entries.Count;
        }

        private void KilledProcessesDialog_Load(object sender, EventArgs e)
        {
            hammerIcon.Image = PwnHammer.Properties.Resources.Pwnhammer.ToBitmap();
            
            Random RandomGen = new Random();
            int randomValue = RandomGen.Next(100);

            if (randomValue < 40)
            {
                label1.Text = String.Format("Aw hell naw he done kilt {0} of the got dam processors! 😢", killedProcsAmount);
            }
            else
            {
                label1.Text = String.Format("PwnHammer killed {0} conflicting processes.", killedProcsAmount);
            }

            this.Icon = PwnHammer.Properties.Resources.Pwnhammer;

            foreach (Entry entry in killedProcs)
            {
                procList.Rows.Add(entry.ConnectionType,
                         entry.IP,
                         entry.Port,
                         entry.DestinationIP,
                         entry.DestinationPort,
                         entry.ConnectionStatus,
                         entry.PID,
                         entry.ProcessName
                         );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
