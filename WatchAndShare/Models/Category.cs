using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatchAndShare.Models
{
    public class Category
    {
        [Key]
        
        public int CatID { get; set; }
        public string CatName { get; set; }

        public virtual ICollection<Anime> Anime { get; set; }
    }
}