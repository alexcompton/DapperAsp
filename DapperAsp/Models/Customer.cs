using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperAsp.Models
{
    public class Customer
    {
        [Display(Name = "Customer ID")]
        public Int32 CustomerID { get; set; }

        [Display(Name = "Name Style")]
        public Boolean NameStyle { get; set; }

        [Display(Name = "Title")]
        public String Title { get; set; }

        [Display(Name = "FirstName")]
        public String FirstName { get; set; }

        [Display(Name = "MiddleName")]
        public String MiddleName { get; set; }

        [Display(Name = "LastName")]
        public String LastName { get; set; }

        [Display(Name = "Suffix")]
        public String Suffix { get; set; }

        [Display(Name = "Company Name")]
        public String CompanyName { get; set; }

        [Display(Name = "Sales Person")]
        public String SalesPerson { get; set; }

        [Display(Name = "Email Address")]
        public String EmailAddress { get; set; }

        [Display(Name = "Phone")]
        public String Phone { get; set; }

        [Display(Name = "Password Hash")]
        public String PasswordHash { get; set; }

        [Display(Name = "Password Salt")]
        public String PasswordSalt { get; set; }

        [Display(Name = "rowguid")]
        public System.Guid rowguid { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }
    }
}