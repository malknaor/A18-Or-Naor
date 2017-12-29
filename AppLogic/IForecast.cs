using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public interface IForecast
    {
        DateTime DateAndTime { get; }

        float Temperture { get; }

        string Description { get; }
    }
}
