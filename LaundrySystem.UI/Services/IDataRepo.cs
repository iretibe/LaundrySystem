using LaundrySystem.UI.Entities;
using System;
using System.Collections.Generic;

namespace LaundrySystem.UI.Services
{
    public interface IDataRepo
    {
        IEnumerable<tblProduct> GetProductUnitPrice(Guid ProductID);
    }
}
