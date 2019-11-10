using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApi.Core
{
    public class LocationId
    {
        public string Title { get; set; }
        public string Location_type { get; set; }
        public int Woeid { get; set; }
        public string Latt_long { get; set; }
    }
   
}
