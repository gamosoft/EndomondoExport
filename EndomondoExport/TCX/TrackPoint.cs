using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndomondoExport.TCX
{
    public class TrackPoint
    {
        public string Time { get; set; }

        public Position Position { get; set; }

        public string AltitudeMeters { get; set; }

        public string DistanceMeters { get; set; }

        public string HeartRateBpm { get; set; }

        public string Cadence { get; set; }

    }
}