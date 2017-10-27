using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorWebApi.Models
{
    public class TResult
    {
        public string arg1 { get; set; }
        public string arg2 { get; set; }
        public string math { get; set; }

        public string result { get; set; }
    }
}