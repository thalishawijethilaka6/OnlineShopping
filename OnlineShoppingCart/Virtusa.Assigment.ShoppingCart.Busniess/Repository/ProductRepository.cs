using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Virtusa.Assigment.ShoppingCart.Busniess.IRepository;
using Virtusa.Assigment.ShoppingCart.Data.Context;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Busniess.Repository
{
    public class ProductRepository : CoreRepository<ProductEntity, OnlineShoppingCartContext>
    {

        public ProductRepository(OnlineShoppingCartContext context) : base(context)
        {

        }

    }
}
