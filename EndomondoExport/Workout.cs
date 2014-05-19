using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndomondoExport
{
    public class Workout
    {
        public string id { get; set; }

        public string start_time { get; set; }

        public string name { get; set; }

        public string sport { get; set; }

        public string distance_km { get; set; }

        public string duration_sec { get; set; }

        public string speed_kmh_avg { get; set; }

        public string route_id { get; set; }
    }

    public class WorkoutList
    {
        public List<Workout> data { get; set; }
    }
}