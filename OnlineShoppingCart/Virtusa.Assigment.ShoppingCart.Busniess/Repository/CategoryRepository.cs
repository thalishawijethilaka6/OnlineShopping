using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Virtusa.Assigment.ShoppingCart.Data.Context;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Busniess.Repository
{
    public class CategoryRepository : CoreRepository<CategoryEntity, OnlineShoppingCartContext>
    {

        public CategoryRepository(OnlineShoppingCartContext context) : base(context)
        {

        }
       
    }
}
