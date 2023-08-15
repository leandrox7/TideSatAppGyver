using System;
namespace Tidesat_AppGyverAPI
{
    public class Sensor
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public bool Status { get; set; }
        public int Id { get; }
        public Location Location { get; set; }
        public int GpsQuality { get; set; }
        public int Batery { get; set; }
        public int InternetQuality { get; set; }

        public Sensor(int id, string name, string code, string description, bool status, Location location)
        {
            Name = name;
            Code = code;
            Description = description;
            Status = status;
            Id = id;
            Location = location;

            GpsQuality = GetRandom(90,99,2323);
            Batery = GetRandom(40,100,44443);
            InternetQuality = GetRandom(20,100,7869);
        }

        private static int GetRandom(int min, int max, int seed)
        {
            int _seed = DateTime.Now.Millisecond;
            _seed = Convert.ToInt32(Math.Abs(DateTime.Now.Second + 1)*(_seed * seed *DateTime.Now.Minute));
            Random rnd = new Random(_seed);
            int value = rnd.Next(min, max);
            return value;
        }
    }
}

