using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class Admin
    {
        [Key]
        public int AdID { get; set; }
        public string AdName { get; set; }
        public string AdGmail { get; set; }
    }
}