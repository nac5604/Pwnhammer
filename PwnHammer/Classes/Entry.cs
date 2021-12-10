using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwnHammer
{
    public class Entry
    {
        public string ConnectionType { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string DestinationIP { get; set; }
        public string DestinationPort { get; set; }
        public string ConnectionStatus { get; set; }
        public string PID { get; set; }

        public string ProcessName { get; set; }

    }
}
