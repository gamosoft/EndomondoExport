using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.GPX
{
    [XmlRootAttribute(Namespace = "http://www.topografix.com/GPX/1/1", IsNullable = false)]
    public class gpx : EndomondoActivity
    {
        [XmlAttribute()]
        public string version { get; set; }

        [XmlAttribute()]
        public string creator { get; set; }

        public metadata metadata { get; set; }

        public trk trk { get; set; }
    }
}