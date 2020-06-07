using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.DataModel
{
    public class CountyResult
    {
        public string Result { get; set; }

        public string Message { get; set; }
        public List<CountryData> Data { get; set; }
        public object HeaderId { get; set; }

    }
}