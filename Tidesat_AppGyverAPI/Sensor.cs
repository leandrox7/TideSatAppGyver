using System;
namespace Tidesat_AppGyverAPI
{
	public class Sensor
	{
		public string Name{get; set;}
        public string Code { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Status { get; set; }
        public int Id { get;}

        public Sensor(int id, string name, string code, string description, string latitude, string longitude, bool status)
        {
            Name = name;
            Code = code;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
            Status = status;
            Id = Id;
        }
    }
}

