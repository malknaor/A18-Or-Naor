using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public abstract class WeatherForecast
    {
        public DateTime DateAndTime { get; set; }

        protected string Location { get; set; }
              
        public abstract void ForecastToList(ref List<string> io_List);
    }
}
