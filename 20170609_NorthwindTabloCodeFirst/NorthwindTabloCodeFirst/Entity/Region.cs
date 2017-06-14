using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindTabloCodeFirst.Entity
{
    public class Region
    {
        public int RegionID { get; set; }
        [Required,MaxLength(50)]
        public string RegionDescription { get; set; }

        public ICollection<Territory> Territory { get; set; }
    }
}