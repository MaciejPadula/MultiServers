using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServers
{
    public class Latest
    {
        public string snapshot { get; set; }
        public string release { get; set; }
    }

    public class Version
    {
        public string id { get; set; }
        public string type { get; set; }
        public DateTime time { get; set; }
        public DateTime releaseTime { get; set; }
        public string url { get; set; }
    }

    public class RootObject
    {
        public Latest latest { get; set; }
        public List<Version> versions { get; set; }
    }
}
