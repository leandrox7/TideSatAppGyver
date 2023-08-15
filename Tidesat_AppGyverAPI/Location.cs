using System;
namespace Tidesat_AppGyverAPI
{
    public class Location
    {
        public Location(Double latitude, Double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            locations = new();
            locations.Add(new MakersLocation(-30.047980, -51.225563));
            locations.Add(new MakersLocation(-30.047980, -51.225563));
            locations.Add(new MakersLocation(-30.047980, -51.225563));

        }

        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public List<MakersLocation> locations { get; set; }
	}


    public class MakersLocation
    {
        public MakersLocation(Double latitude, Double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            Description = "Localização do sensor";
            Title = "Sensor";
            IconColor = "#ff0";
            Description = "Localização do sensor";
            IconName = "Teste";
            Label = "tetste";
            LabelColor = "#ff0";
            IconSize = 20;         }

        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string IconColor { get; set; }
        public string IconName { get; set; }
        public int IconSize { get; set; }
        public string Label { get; set; }
        public string LabelColor { get; set; }

    }
}

