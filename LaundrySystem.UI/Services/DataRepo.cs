using System.Resources;
using LaundrySystem.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using LaundrySystem.UI.Models;

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

        public void AddOrder(OrderModel order) 
        {
            tblSale sale = new tblSale();

            sale.SaleTotal = order.SaleTotal;
            sale.Discount = order.Discount;
            sale.NetTotal = order.NetTotal;
            sale.Balance = order.Balance;
            sale.CustomerId = order.CustomerId;
            sale.OrderStatusID = order.ServiceId;
            //sale.CustomerName = order.CustomerName;
            //sale.ServiceName = order.ServiceName;

            _context.tblSale.Add(sale);
            _context.SaveChanges();

            Guid uniSaleId = sale.SaleId;

            foreach (var item in order.ListOfOrderDetails)
            {
                tblSaleDetail saleDtails = new tblSaleDetail();

                saleDtails.SaleID = uniSaleId;
                saleDtails.ProductId = item.ProductId;
                saleDtails.ProductName = item.ProductName;
                saleDtails.QtySold = item.QtySold;
                saleDtails.SellingPrice = item.SellingPrice;
                saleDtails.SaleDetailTotal = item.SaleDetailTotal;

                _context.tblSaleDetail.Add(saleDtails);
                _context.SaveChanges();
            }
        }
    }
}
