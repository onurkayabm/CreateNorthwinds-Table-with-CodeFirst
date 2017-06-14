using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwindTabloCodeFirst.Entity
{
    public class Category
    {
        [Key,Required]
        public int CategoryID { get; set; }
        [MaxLength(15),Required]
        public string CategoryName { get; set; }
        
        public string Description { get; set; }
        public byte?[] Picture { get; set; }

        public virtual ICollection<Product> Product { get; set; }

    }
}