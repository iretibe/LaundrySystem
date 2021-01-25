using LaundrySystem.UI.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaundrySystem.UI.Services
{
    public class CustomerRepo : ICustomerRepo
    {
        private LaundrydbContext _context;

        public CustomerRepo()
        {
            _context = new LaundrydbContext();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var obj = new List<SelectListItem>();
            obj = (from p in _context.tblCustomer
                   select new SelectListItem()
                   {
                       Text = p.CustomerName,
                       Value = p.CustomerID.ToString(),
                       Selected = true
                   }).ToList();

            return obj;
        }
    }
}
