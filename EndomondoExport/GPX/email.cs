using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.GPX
{
    public class email
    {
        [XmlAttribute()]
        public string id { get; set; }

        [XmlAttribute()]
        public string domain { get; set; }
    }
}