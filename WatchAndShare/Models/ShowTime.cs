using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class ShowTime
    {
        public int STID { get; set; }
        public Cinema CiID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}