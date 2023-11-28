using Clean.Application.DTOs;
using Clean.Application.Interfaces;
using Clean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            this._repo = repo;
        }
        public Dto GetProduct()
        {
            return new Dto()
            {

                Products = _repo.GetProduct()
            };
        }
    }
}
