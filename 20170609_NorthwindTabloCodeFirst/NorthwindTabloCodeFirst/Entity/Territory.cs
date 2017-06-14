using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindTabloCodeFirst.Entity
{
    public class Territory
    {
        [Key,MaxLength(20)]
        public string TerritoryID { get; set; }
        [Required]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }

        public virtual Region Region { get; set; }

    }
}