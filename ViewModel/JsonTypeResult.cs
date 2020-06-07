﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.ViewModel
{
    public class JsonTypeResult
    {
        public bool Result { get; set; }

        public string Message { get; set; }
        public object Data { get; set; }
    }
}