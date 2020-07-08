using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Virtusa.Assigment.ShoppingCart.Data.Entity
{
   public class ProductEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CategryId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public bool StockAvailability { get; set; }
        public int Qty { get; set; }
        public int UnitPrice { get; set; }
        public int SellingPrice { get; set; }
        public int Discount { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}
