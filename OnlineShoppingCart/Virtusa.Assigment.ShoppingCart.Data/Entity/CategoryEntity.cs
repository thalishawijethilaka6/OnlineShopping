
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Virtusa.Assigment.ShoppingCart.Data.Entity
{
    public class CategoryEntity : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public ICollection<ProductEntity> ProductEntities { get; set; }
    }
}
