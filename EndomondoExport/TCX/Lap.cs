using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EndomondoExport.TCX
{
    public class Lap
    {
        [XmlAttribute()]
        public string StartTime { get; set; }

        public string TotalTimeSeconds { get; set; }

        public string DistanceMeters { get; set; }

        public string MaximumSpeeed { get; set; }
        
        public string Calories { get; set; }

        public string AverageHeartRateBpm { get; set; }

        public string MaximumHeartRateBpm { get; set; }

        public string Intensity { get; set; }

        public string Cadence { get; set; }

        public string TriggerMethod { get; set; }

        public List<TrackPoint> Track { get; set; }

    }
}