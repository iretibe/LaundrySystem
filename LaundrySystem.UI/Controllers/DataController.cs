using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LaundrySystem.UI.Controllers
{
    public class DataController : Controller
    {
        private LaundrydbContext _context;
        private IDataRepo _dataRepo;

        public DataController(LaundrydbContext context, IDataRepo dataRepo)
        {
            _context = context;
            _dataRepo = dataRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUnitPriceByProductId(Guid ProductID)
        {
            var obj = _dataRepo.GetProductUnitPrice(ProductID);
            return Ok(obj);
        }
    }
}
