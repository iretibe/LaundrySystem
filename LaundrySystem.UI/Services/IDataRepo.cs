using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using System;
using System.Collections.Generic;

namespace LaundrySystem.UI.Services
{
    public interface IDataRepo
    {
        IEnumerable<tblProduct> GetProductUnitPrice(Guid ProductID);
        void AddOrder(OrderModel order);
    }
}
