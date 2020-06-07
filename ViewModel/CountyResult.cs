using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKSTNewServiceDemoApp.Models
{
    public class CountyResult
    {
        public string Result { get; set; }

        public string Message { get; set; }
        public List<CountryData> Data { get; set; }
        public object HeaderId { get; set; }

    }
}
