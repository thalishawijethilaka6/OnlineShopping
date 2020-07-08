using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Virtusa.Assigment.ShoppingCart.Busniess.Repository;
using Virtusa.Assigment.ShoppingCart.Data.Context;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<ProductEntity, ProductRepository>
    {
    
        private readonly OnlineShoppingCartContext _context;

        public ProductController(ProductRepository repository, OnlineShoppingCartContext context) : base(repository)
        {
            this._context = context;
        }
        [HttpGet("products/{id}")]
        public async Task<ActionResult<IEnumerable<ProductEntity>>> GetCategoryEntity(int id)
        {
            var productEntity = await _context.products.Where(e => e.CategryId == id).ToListAsync();

            if (productEntity == null)
            {
                return NotFound();
            }

            return productEntity;
        }
    }
}
