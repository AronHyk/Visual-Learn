using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{

    public class Rootobject
    {
        public string Version { get; set; }
        public Defaults Defaults { get; set; }
        public Configuration[] Configurations { get; set; }
    }

    public class Defaults
    {
    }

    public class Configuration
    {
        public string Type { get; set; }
        public string Project { get; set; }
        public string name { get; set; }
        public string[] args { get; set; }
    }

}
