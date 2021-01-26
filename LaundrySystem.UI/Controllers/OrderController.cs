using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace LaundrySystem.UI.Controllers
{
    public class OrderController : Controller
    {
        private LaundrydbContext _context;
        private IDataRepo _dataRepo;

        public OrderController(LaundrydbContext context, IDataRepo dataRepo)
        {
            _context = context;
            _dataRepo = dataRepo;
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
        }


        public void PostOrderTransaction(OrderModel objModel) 
        {
            _dataRepo.AddOrder(objModel);
        }
    }
}
