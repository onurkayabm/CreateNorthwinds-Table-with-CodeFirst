using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwindTabloCodeFirst.Entity
{
    public class Product
    {
        [Required,Key]
        public int ProductID { get; set; }
        [Required,MaxLength(40)]
        public string ProductName { get; set; }

        public int   SupplierID { get; set; }
        public int CategoryID { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

        public decimal?  UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }

        [Required]
        public byte Discontinued { get; set; }


        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}