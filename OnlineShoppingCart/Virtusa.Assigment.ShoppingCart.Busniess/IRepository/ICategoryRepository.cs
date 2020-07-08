using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Busniess.IRepository
{
    public interface ICategoryRepository : IRepository<CategoryEntity>
    {
        Task<CategoryEntity> GetProducts(int id);

    }
}
