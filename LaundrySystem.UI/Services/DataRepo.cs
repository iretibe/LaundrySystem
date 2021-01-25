using LaundrySystem.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaundrySystem.UI.Services
{
    public class DataRepo : IDataRepo
    {
        private LaundrydbContext _context;

        public DataRepo()
        {
            _context = new LaundrydbContext();
        }

        public IEnumerable<tblProduct> GetProductUnitPrice(Guid ProductID)
        {
            return _context.tblProduct.Where(p => p.ProductID == ProductID).ToList();
        }
    }
}
