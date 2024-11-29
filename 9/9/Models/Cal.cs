using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _9.Models
{
    public class Cal
    {
        [Display(Name = "First Number")]
        public double Number1 { get; set; }

        [Display(Name = "Second Number")]
        public double Number2 { get; set; }

        [Display(Name = "Operation")]
        public string Operation { get; set; }

        [Display(Name = "Result")]
        public double? Result { get; set; }

        public bool IsAdvancedOperation { get; set; }
    }
}