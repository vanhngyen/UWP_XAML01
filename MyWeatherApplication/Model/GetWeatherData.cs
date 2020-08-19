﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;

namespace MyWeatherApplication.Model
{
    public class GetWeatherData
    {
        public async static Task<RootObject> getOpenWeather()
        {
            var http = new HttpClient();
            var response = await http.GetAsync("https://api.openweathermap.org/data/2.5/weather?lat=21.0292&lon=105.8525&units=metric&appid=ad2af13fcd1d898ac10c70bd44630f47");
            var result = await response.Content.ReadAsStringAsync(); //bóc tách nội dung của data
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var data = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var value = (RootObject)serializer.ReadObject(data);
            return value;
        }

        //Get Weather Data
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Main
        {
            public int temp { get; set; }
            public double feels_like { get; set; }
            public int temp_min { get; set; }
            public int temp_max { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
            public int deg { get; set; }
        }

        public class Clouds
        {
            public int all { get; set; }
        }

        public class Sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        }

        public class RootObject
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            //public string @base { get; set; }
            public Main main { get; set; }
            public int visibility { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public int dt { get; set; }
            public Sys sys { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }
    }
}
