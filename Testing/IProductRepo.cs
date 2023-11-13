using System.Collections.Generic;
using System;
using Testing.Models;

namespace Testing
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

    }
}
