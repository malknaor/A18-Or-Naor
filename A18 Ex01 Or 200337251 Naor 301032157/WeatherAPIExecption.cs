using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI_namespace
{
    class WeatherAPIExecption : Exception
    {
        public WeatherAPIExecption(string i_Message)
            : base (i_Message)
        {

        }
    }
}
