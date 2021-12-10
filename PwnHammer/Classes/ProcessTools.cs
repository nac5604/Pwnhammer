using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwnHammer
{
    public static class ProcessTools
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        // Adds the Administrator shield icon to a button.
        public static void AddShieldToButton(Button btn)
        {
            const Int32 BCM_SETSHIELD = 0x160C;

            btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            SendMessage(btn.Handle, BCM_SETSHIELD, 0, 1);
        }

        // Disables a service.
        public static void DisableService(int pid, string procName)
        {
            if (IsService(pid))
            {
                ProcessStartInfo process = new ProcessStartInfo("cmd", String.Format("sc config {0} start=demand", procName));

                process.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.UseShellExecute = false;
                process.CreateNoWindow = true;

                Process p = new Process();
                p.StartInfo = process;
                p.Start();

                process = new ProcessStartInfo("cmd", String.Format("sc stop {0}", procName));

                p.StartInfo = process;
                p.Start();
            }
        }

        // Kills a process tree.
        public static void KillProcessAndChildren(int pid)
        {
            if (pid == 0)
            {
                return;
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();

            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(int.Parse(mo["ProcessID"].ToString()));
            }

            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {

            }
        }

        // Checks if the program has been run as Administrator.
        public static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        // Checks if a program is a service.
        public static bool IsService(int pID)
        {
            using (ManagementObjectSearcher Searcher = new ManagementObjectSearcher(
            "SELECT * FROM Win32_Service WHERE ProcessId =" + "\"" + pID + "\""))
            {
                foreach (ManagementObject service in Searcher.Get())
                    return true;
            }
            return false;
        }

    }
}
