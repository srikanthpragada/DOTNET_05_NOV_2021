using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspnetmvcdemo.Models
{
    public class Interest
    {
        [Range(1000, Int32.MaxValue, ErrorMessage = "Amount must be > {1}")]
        public int Amount { get; set; }

        [Range(5,50, ErrorMessage = "Invalid Interest Rate! It must be {1} - {2}")]
        public int Rate { get; set; }
        public int Result { get; set; }
    }
}