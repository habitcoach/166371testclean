using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.DTOs
{
    public class Dto
    {
        public IEnumerable<Product> Products { get; set; }

        
    }
}
