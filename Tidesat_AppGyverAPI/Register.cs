using System;
namespace Tidesat_AppGyverAPI
{
	public class Register
	{
		public int Id { get; }
		public int Sensor { get; }
		public int RHm { get; set; }
		public DateTime Date {get; set;}



        public Register(int id, int sensor, int rHm, DateTime date)
        {
            Id = id;
            Sensor = sensor;
            RHm = rHm;
            Date = date;
        }
    }
}

