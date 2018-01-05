using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public abstract class WeatherForecast
    {
        protected DateTime DateAndTime { get; set; }

        protected float Temperture { get; set; }

        protected string Description { get; set; }

        protected string Location { get; set; }

        public override string ToString()
        {
            return Location + ": "+ DateAndTime.ToString() + ", Temp: " + Temperture.ToString() + ", " + Description + "."; ;
        }
    }
}
