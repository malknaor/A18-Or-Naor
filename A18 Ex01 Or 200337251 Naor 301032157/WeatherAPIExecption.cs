using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    class WeatherAPIExecption : Exception
    {
        public WeatherAPIExecption(string i_Message)
            : base (i_Message)
        {

        }
    }
}
