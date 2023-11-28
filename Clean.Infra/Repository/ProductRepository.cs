using Clean.Domain.Interfaces;
using Clean.Domain.Models;
using Clean.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly RestaurantDBContext _context;

        public ProductRepository(RestaurantDBContext context)
        {
            this._context = context;
        }
        public IEnumerable<Product> GetProduct()
        {
            return _context.Products;
        }
    }
}
