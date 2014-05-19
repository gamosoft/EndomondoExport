using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndomondoExport.GPX
{
    public class trk
    {
        public string name { get; set; }

        public string src { get; set; }

        public link link { get; set; }

        public string type { get; set; }

        public List<trkpt> trkseg { get; set; }
    }
}