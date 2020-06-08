using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.DataModel
{
    public class JsonTypeResult
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public List<NotificationHistory> Data { get; set; }
    }
}