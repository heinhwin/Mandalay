using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mandalay.Models
{
    public class FakeProductRepository:IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Tom Yum", Price = 13},
            new Product { Name = "Roasted Duck", Price = 30},
            new Product { Name = "Water", Price = 2}
        }.AsQueryable<Product>();
    }
}
