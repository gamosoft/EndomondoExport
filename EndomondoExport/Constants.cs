using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndomondoExport
{
    /// <summary>
    /// All constants and enumerations to be defined here
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// All types of activities
        /// </summary>
        public enum SportType
        {
            Running = 0,
            CyclingTransport = 1,
            CyclingSport = 2,
            MountainBiking = 3,
            Skating = 4,
            RollerSkiing = 5,
            SkiingCrossCountry = 6,
            SkiingDownhill = 7,
            Snowboarding = 8,
            Kayaking = 9,
            KiteSurfing = 10,
            Rowing = 11,
            Sailing = 12,
            Windsurfing = 13,
            FitnessWalking = 14,
            Golfing = 15,
            Hiking = 16,
            Orienteering = 17,
            Walking = 18,
            Riding = 19,
            Swimming = 20,
            Spinning = 21,
            Other = 22,
            Aerobics = 23,
            Badminton = 24,
            Baseball = 25,
            Basketball = 26,
            Boxing = 27,
            ClimbingStairs = 28,
            Cricket = 29,
            CrossTraining = 30,
            Dancing = 31,
            Fencing = 32,
            FootballAmerican = 33,
            FootballRugby = 34,
            FootballSoccer = 35,
            Handball = 36,
            Hockey = 37,
            Pilates = 38,
            Polo = 39,
            ScubaDiving = 40,
            Squash = 41,
            TableTennis = 42,
            Tennis = 43,
            VolleyballBeach = 44,
            VolleyballIndoor = 45,
            WeightTraining = 46,
            Yoga = 47,
            MartialArts = 48,
            Gymnastics = 49,
            StepCounter = 50
        }

        public const string EndomondoAPIUrl = "https://api.mobile.endomondo.com/mobile";
    }
}