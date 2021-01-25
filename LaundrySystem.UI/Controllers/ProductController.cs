using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class ProductController : Controller
    {
        private LaundrydbContext _context;

        public ProductController(LaundrydbContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            //var query = (from p in _context.tblProduct
            //       join s in _context.tblService
            //       on p.ServiceID equals s.ServiceId
            //       join a in _context.AspNetUsers
            //       on p.CreatedBy equals Guid.Parse(a.Id)
            //       select new ProductModel
            //       {
            //           ProductID = p.ProductID,
            //           ServiceID = p.ServiceID,
            //           ProductName = p.ProductName,
            //           ProductPrice = p.ProductPrice,
            //           ProductImage = p.ProductImage,
            //           ProductDescription = p.ProductDescription,
            //           AddedDate = p.AddedDate,
            //           CreatedBy = p.CreatedBy,
            //           ServiceName = s.ServiceName,
            //           UserName = a.UserName
            //       });

            //return View(await query.ToListAsync());

            return View(await _context.tblProduct.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.tblProduct
                .FirstOrDefaultAsync(m => m.ProductID == id);

            //var product = await (from p in _context.tblProduct
            //             join s in _context.tblService
            //             on p.ServiceID equals s.ServiceId
            //             join a in _context.AspNetUsers
            //             on p.CreatedBy equals Guid.Parse(a.Id)
            //             where p.ProductID == id
            //             select new ProductModel
            //             {
            //                 ProductID = p.ProductID,
            //                 ServiceID = p.ServiceID,
            //                 ProductName = p.ProductName,
            //                 ProductPrice = p.ProductPrice,
            //                 ProductImage = p.ProductImage,
            //                 ProductDescription = p.ProductDescription,
            //                 AddedDate = p.AddedDate,
            //                 CreatedBy = p.CreatedBy,
            //                 ServiceName = s.ServiceName,
            //                 UserName = a.UserName
            //             }).ToListAsync();
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductPrice,ProductImage,ProductDescription,AddedDate,CreatedBy")] tblProduct product)
        {
            if (ModelState.IsValid)
            {
                product.ProductID = Guid.NewGuid();
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { id = product.ProductID });
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.tblProduct.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProductID,ProductName,ProductPrice,ProductImage,ProductDescription,AddedDate,CreatedBy")] tblProduct product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.tblProduct
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var product = await _context.tblProduct.FindAsync(id);
            _context.tblProduct.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
            return _context.tblProduct.Any(e => e.ProductID == id);
        }

        //public JsonResult GetProductUnitPrice(Guid ProductID)
        //{
        //    decimal? UnitPrice = _context.tblProduct.Single(p => p.ProductID == ProductID).ProductPrice;
        //    //return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        //    return Json(UnitPrice);
        //}
    }
}
