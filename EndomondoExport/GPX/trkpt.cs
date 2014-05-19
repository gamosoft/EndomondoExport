using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.GPX
{
    public class trkpt
    {
        [XmlAttribute()]
        public string lat { get; set; }

        [XmlAttribute()]
        public string lon { get; set; }

        public string ele { get; set; }

        public string time { get; set; }

    }
}