using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.DataModel
{
    public class NotificationHistory
    {
  
            public string HEADERID { get; set; }
            public string SENDER { get; set; }
            public string RECEIVER { get; set; }
            public string WAYBILLNUMBER { get; set; }
            public string WAYBILLDATE { get; set; }
            public string HEADERSTATE { get; set; }
            public string OPERATION { get; set; }
            public int DETAILCOUNT { get; set; }

    }
}