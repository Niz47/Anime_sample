using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class Cinema
    {
      [Key]
        public int CiID { get; set; }
        public string CiName { get; set; }
        public string Location { get; set; }
    }
}