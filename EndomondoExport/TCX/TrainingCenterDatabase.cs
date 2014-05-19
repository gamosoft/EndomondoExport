using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.TCX
{
    [XmlRootAttribute(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", IsNullable = false)]
    public class TrainingCenterDatabase : EndomondoActivity
    {
        public List<Activity> Activities { get; set; }
    }
}