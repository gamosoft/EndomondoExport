using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.TCX
{

    public class Activity
    {
        [XmlAttribute()]
        public string Sport { get; set; }

        public string Id { get; set; }

        public Lap Lap { get; set; }

        public string Notes { get; set; }
    }
}