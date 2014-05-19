using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.GPX
{
    public class link
    {
        [XmlAttribute()]
        public string href { get; set; }

        public string text { get; set; }
    }
}