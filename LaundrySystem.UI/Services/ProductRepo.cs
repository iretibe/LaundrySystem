using LaundrySystem.UI.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaundrySystem.UI.Services
{
    public class ProductRepo : IProductRepo
    {
        private LaundrydbContext _context;

        public ProductRepo()
        {
            _context = new LaundrydbContext();
        }

        public IEnumerable<SelectListItem> GetAllProducts()
        {
            var obj = new List<SelectListItem>();
            obj = (from p in _context.tblProduct
                   select new SelectListItem()
                   {
                       Text = p.ProductName,
                       Value = p.ProductID.ToString(),
                       Selected = true
                   }).ToList();

            return obj;
        }
    }
}
