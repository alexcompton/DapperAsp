using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperAsp.Models
{
    public class CustomerRequest
    {
        [Display(Name = "Search String")]
        public string SearchString { get; set; }
    }
}