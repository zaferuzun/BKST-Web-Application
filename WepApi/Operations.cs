﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje1.WebApi
{
    public class Operations
    {
        public static string GetJson(object type)
        {

            return JsonConvert.SerializeObject(type);
        }
    }
}