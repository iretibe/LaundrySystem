using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class OrderController : Controller
    {
        private LaundrydbContext _context;

        public OrderController(LaundrydbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CustomerRepo custRepo = new CustomerRepo();
            ProductRepo prodRepo = new ProductRepo();
            ServiceRepo servRepo = new ServiceRepo();

            var objMultipleModels =
                new Tuple<IEnumerable<SelectListItem>,
                IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (custRepo.GetAllCustomers(), prodRepo.GetAllProducts(), servRepo.GetAllServices());

            return View(objMultipleModels);

            //List<spSelectSaleDetails> lst;
            //_context.Database.OpenConnection();
            //using (DbCommand cmdObj = _context.Database.GetDbConnection().CreateCommand())
            //{
            //    cmdObj.CommandText = "spSelectSaleDetails";
            //    cmdObj.CommandType = CommandType.StoredProcedure;

            //    using (var drObj = cmdObj.ExecuteReader())
            //    {
            //        lst = drObj.MapToList<spSelectSaleDetails>();
            //    }
            //}
            ////var data = (from s in _context.tblSale
            ////            join c in _context.tblCustomer
            ////            on s.CustomerId equals c.CustomerID
            ////            );
            ////var sales = _context.tblSale.Include(s => s.tblCustomer.).Include(s => s.Journal);
            ////return View(sales.ToList());
            //return View(lst);
        }



        //public ActionResult Create()
        //{
        //    ViewBag.CustomerID = new SelectList(_context.tblCustomer, "CustomerID", "CustomerName");
        //    ViewBag.Journal_ID = new SelectList(_context.tblProduct, "ProductID", "ProductName");
        //    return View();
        //}

        //// POST: Sales/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(SaleModel sale)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.tblSale.Add(sale);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CustomerID = new SelectList(_context.tblCustomer, "CustomerID", "CustomerName", sale.CustomerId);
        //    //ViewBag.ProductID = new SelectList(_context.tblProduct, "ProductID", "ProductName", sale.Product);
        //    return View(sale);
        //}

    }
}
