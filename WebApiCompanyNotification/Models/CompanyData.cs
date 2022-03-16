using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCompanyNotification.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int CompanyNumber { get; set; }
        public string CompanyType { get; set; }
        public string Market { get; set; }
    }

    public class Notification
    {
        [Key]
        public int CompanyID { get; set; }
        public DateTime SendDate { get; set; }


    }
}
