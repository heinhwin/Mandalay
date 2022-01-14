﻿using System.Collections.Generic;
using Mandalay.Models;


namespace Mandalay.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
