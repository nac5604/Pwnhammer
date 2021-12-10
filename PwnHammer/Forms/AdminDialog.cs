using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwnHammer
{
    public partial class AdminDialog : Form
    {
        public AdminDialog()
        {
            InitializeComponent();
        }

        private void AdminDialog_Load(object sender, EventArgs e)
        {
            ProcessTools.AddShieldToButton(restartBtn);
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo elevated = new ProcessStartInfo(System.Reflection.Assembly.GetEntryAssembly().Location, "run2");
            elevated.UseShellExecute = true;
            elevated.Verb = "runas";
            Process.Start(elevated);
            Application.Exit();
        }
    }
}
