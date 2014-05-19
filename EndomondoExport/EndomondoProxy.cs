using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EndomondoExport
{
	public class EndomondoProxy
	{
		public string UserId { get; set; }

		public string DisplayName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }
		
		public string AuthToken { get; set; }

		public bool IsAuthenticated {
			get {
				return !String.IsNullOrEmpty(this.AuthToken);
			}
		}

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="email">Email address</param>
		/// <param name="password">Password</param>
		public EndomondoProxy(string email, string password)
		{
			this.Email = email;
			this.Password = password;
		}



		public bool Authenticate()
		{
			bool result = false;
			string authUrl = String.Format("{0}/auth?deviceId=dummy&email={1}&password={2}&country=US&action=PAIR",
				 Constants.EndomondoAPIUrl, this.Email, this.Password);
			string str = this.MakeWebRequest(authUrl);
			if (!String.IsNullOrEmpty(str))
			{
				string[] lines = str.Split('\n');
				if (lines[0] != "OK")
				{
					// TODO: Error
				}
				else
				{
					foreach (string line in lines)
					{
						string[] values = line.Split('=');
						if (values.Length == 2)
						{
							switch (values[0])
							{
								case "authToken":
									this.AuthToken = values[1];
									result = true;
									break;
								case "displayName":
									this.DisplayName = values[1];
									break;
								case "userId":
									this.UserId = values[1];
									break;
								default:
									// Nothing
									break;
							}
						}
					}
				}
			}
			return result;
		}

		public WorkoutList ListWorkouts(int maxResults)
		{
			string listUrl = String.Format("{0}/api/workout/list?authToken={1}&maxResults={2}",
				 Constants.EndomondoAPIUrl, this.AuthToken, maxResults);
			string str = this.MakeWebRequest(listUrl);
			WorkoutList list = new JavaScriptSerializer().Deserialize<WorkoutList>(str);
			return list;
		}

		public EndomondoActivity RetrieveWorkout(string workoutId, string extension)
		{
			if (extension == "tcx")
				return RetrieveTCXWorkout(workoutId);
			else
				return RetrieveGPXWorkout(workoutId);
		}

		public GPX.gpx RetrieveGPXWorkout(string workoutId)
		{
			GPX.gpx gpx = null;
			string workoutUrl = String.Format("{0}/readTrack?authToken={1}&trackId={2}",
				 Constants.EndomondoAPIUrl, this.AuthToken, workoutId);
			string str = this.MakeWebRequest(workoutUrl);
			if (!String.IsNullOrEmpty(str))
			{
				string[] lines = str.Split('\n');
				if (lines[0] != "OK")
				{
					// TODO: Error
				}
				else
				{
					// Info from the activity
					string[] info = lines[1].Split(';');
					if (info.Length >= 9)
					{
						string[] emailfields = this.Email.Split('@');
						gpx = new GPX.gpx()
						{
							FullContents = str,
							version = "1.1",
							creator = "Endomondo Export",
							metadata = new GPX.metadata()
							{
								author = new GPX.author()
								{
									email = new GPX.email()
									{
										id = emailfields[0],
										domain = emailfields[1]
									},
									name = this.DisplayName
								},
								link = new GPX.link() {
									href = "https://endomondoexport.codeplex.com",
									text = "Endomondo Export"
								},
								time = UTCTime(info[1])
							},
							trk = new GPX.trk()
							{
								name = info[4],
								src = "https://endomondoexport.codeplex.com",
								link = new GPX.link()
								{
									href = "https://endomondoexport.codeplex.com",
									text = "Endomondo Export"
								},
								type = Enum.GetName(typeof(Constants.SportType), int.Parse(info[5])),
								trkseg = new List<GPX.trkpt>()
							},
						};


						for (int i = 2; i < lines.Length; i++)
						{
							string[] values = lines[i].Split(';');
							if (values.Length >= 9)
							{
								gpx.trk.trkseg.Add(new GPX.trkpt()
								{
									lat = values[2],
									lon = values[3],
									ele = values[6],
									time = UTCTime(values[0])
								});
							}
						}
					};
				}
			}
			return gpx;
		}

		public TCX.TrainingCenterDatabase RetrieveTCXWorkout(string workoutId)
		{
			TCX.TrainingCenterDatabase db = null;
			string workoutUrl = String.Format("{0}/readTrack?authToken={1}&trackId={2}",
				 Constants.EndomondoAPIUrl, this.AuthToken, workoutId);
			string str = this.MakeWebRequest(workoutUrl);
			if (!String.IsNullOrEmpty(str))
			{
				string[] lines = str.Split('\n');
				if (lines[0] != "OK")
				{
					// TODO: Error
				}
				else
				{
					// Info from the activity
					string[] info = lines[1].Split(';');
					if (info.Length >= 9) {
						db = new TCX.TrainingCenterDatabase()
						{
							FullContents = str,
							Activities = new List<TCX.Activity>()
						};
						TCX.Activity activity = new TCX.Activity()
						{
							Id = UTCTime(info[1]),
							Sport = Enum.GetName(typeof(Constants.SportType), int.Parse(info[5])),
							Lap = new TCX.Lap()
							{
								StartTime = UTCTime(info[6]),
								TotalTimeSeconds = info[7],
								DistanceMeters = (double.Parse(info[8])*1000).ToString(),
								Calories = info[9],
								Intensity = "Active",
								TriggerMethod = "Manual",
								MaximumHeartRateBpm = info[13],
								AverageHeartRateBpm = info[14],
								Track = new List<TCX.TrackPoint>()
							}
						};
					   
						for (int i = 2; i < lines.Length; i++)
						{
							string[] values = lines[i].Split(';');
							if (values.Length >= 9)
							{
								activity.Lap.Track.Add(new TCX.TrackPoint()
								{
									Time = UTCTime(values[0]),
									Position = new TCX.Position()
									{
										LatitudeDegrees = values[2], LongitudeDegrees = values[3]
									},
									AltitudeMeters = values[6],
									DistanceMeters = (double.Parse(values[4]) * 1000).ToString(),
									HeartRateBpm = values[7]
								});
							}
						}
						db.Activities.Add(activity);
					};
				}
			}
			return db;
		}

		private string UTCTime(string date)
		{
			// 2014-04-05 18:29:30 UTC
			// 2014-04-05T18:29:30Z
			return date.Replace(" UTC", "Z").Replace(" ", "T");
		}

		private string MakeWebRequest (string url)
		{
			string result = String.Empty;
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = "GET";
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				if (response.StatusCode == HttpStatusCode.OK)
				{

					Stream receiveStream = response.GetResponseStream();
					StreamReader readStream = null;
					if (response.CharacterSet == null)
						readStream = new StreamReader(receiveStream);
					else
						readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
					string data = readStream.ReadToEnd();
					response.Close();
					readStream.Close();

					result = data;
				}
			}
			return result;
		}

	}
}