using System;
namespace Tidesat_AppGyverAPI
{
    public class Register
    {
        public int Id { get; }
        public int IdSensor { get; }
        public int RHm { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }



        public Register(int id, int sensor, int rHm, DateTime date)
        {
            Id = id;
            IdSensor = sensor;
            RHm = rHm;
            Date = date;
            Description = $" Identificador da Medição: {id}     -    Identificador do Sensor: {sensor}     -     Valor medido: {rHm}    -    Horário:  {date.ToString()}";       }
    }
}

