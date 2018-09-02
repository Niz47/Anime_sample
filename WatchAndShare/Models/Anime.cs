using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class Anime
    {
        [Key]
        public int AID { get; set; }
        public string AName { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDT { get; set; }
    }
}