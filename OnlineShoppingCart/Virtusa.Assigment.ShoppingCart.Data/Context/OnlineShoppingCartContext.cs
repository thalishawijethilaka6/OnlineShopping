using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Data.Context
{
    public class OnlineShoppingCartContext : DbContext
    {

        public OnlineShoppingCartContext(DbContextOptions<OnlineShoppingCartContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> products { get; set; }
    }
}
