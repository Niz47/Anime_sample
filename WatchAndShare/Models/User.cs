using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class User
    {
        public int UID { get; set; }
        public string UName { get; set; }
        public DateTime DOB { get; set; }
        public string UGmail { get; set; }
    }
}