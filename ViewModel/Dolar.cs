using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.ViewModel
{
    public class Dolar
    {
        //public string market { get; set; }
        //public string names { get; set; }
        //public string name { get; set; }
        //public string exchange { get; set; }
        //public string titles { get; set; }
        //public string title { get; set; }
        //public string key { get; set; }
        //public string group { get; set; }

        //public List<SelectListItem> dolarApi { get; set; }


        //public Dolar(string json)
        //{
        //    JObject jObject = JObject.Parse(json);
        //    JToken jUser = jObject["user"];
        //    close = (string)jUser["name"];
        //    date = (string)jUser["teamname"];
        //    high = (string)jUser["email"];
        //    low = (string)jUser["email"];
        //    open = (string)jUser["email"];
        //    value = (string)jUser["email"];
        //    volume = (string)jUser["email"];
        //}
        //[JsonProperty("close")]
        //public double Close { get; set; }

        //[JsonProperty("date")]
        //public long Date { get; set; }

        //[JsonProperty("high")]
        //public double High { get; set; }

        //[JsonProperty("low")]
        //public double Low { get; set; }

        //[JsonProperty("open")]
        //public double Open { get; set; }

        //[JsonProperty("value")]
        //public long Value { get; set; }

        //[JsonProperty("volume")]
        //public long Volume { get; set; }

        //public partial class Temperatures
        //{
        //    [JsonProperty("dataSet")]
        //public List<Dolar> DataSet { get; set; }
        //}

        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}