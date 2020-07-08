using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Virtusa.Assigment.ShoppingCart.Busniess.Repository;
using Virtusa.Assigment.ShoppingCart.Data.Context;
using Virtusa.Assigment.ShoppingCart.Data.Entity;

namespace Virtusa.Assigment.ShoppingCart.Sever.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<CategoryEntity, CategoryRepository>
    {
        public CategoryController(CategoryRepository repository) : base(repository)
        {


        }
    }
}
