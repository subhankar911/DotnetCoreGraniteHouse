using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models.ViewModel
{
    public class ProductsViewModel
    {
        //[BindProperty]
        public Products Products { get; set; }
       // [BindProperty]
        public IEnumerable<ProductTypes> ProductTypes { get; set; }
       // [BindProperty]
        public IEnumerable<SpecialTags> SpecialTags { get; set; }
    }
}
