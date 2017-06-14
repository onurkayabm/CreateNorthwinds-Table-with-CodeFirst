using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindTabloCodeFirst.Entity
{
    public class Shipper
    {
        [Key]
        public int ShipperID { get; set; }
        [Required][MaxLength(40)]
        public string CompanyName { get; set; }
       
        [MaxLength(24)]
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}