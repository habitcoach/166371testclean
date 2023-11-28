using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProduct();
    }
}
