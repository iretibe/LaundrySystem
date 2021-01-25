using LaundrySystem.UI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class CustomerController : Controller
    {
        private LaundrydbContext _context;

        public CustomerController(LaundrydbContext context)
        {
           _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
           return View(await _context.tblCustomer.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
           if (id == null)
           {
               return NotFound();
           }

           var product = await _context.tblCustomer
               .FirstOrDefaultAsync(m => m.CustomerID == id);
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
        public async Task<IActionResult> Create([Bind("CustomerID,CustomerName,PhoneNo,Email,Address,City,AddedDate")] tblCustomer product)
        {
           if (ModelState.IsValid)
           {
               product.CustomerID = Guid.NewGuid();
               _context.Add(product);
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Edit), new { id = product.CustomerID });
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

           var product = await _context.tblCustomer.FindAsync(id);
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
        public async Task<IActionResult> Edit(Guid id, [Bind("CustomerID,CustomerName,PhoneNo,Email,Address,City,AddedDate")] tblCustomer product)
        {
           if (id != product.CustomerID)
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
                   if (!ProductExists(product.CustomerID))
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

           var product = await _context.tblCustomer
               .FirstOrDefaultAsync(m => m.CustomerID == id);
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
           var product = await _context.tblCustomer.FindAsync(id);
           _context.tblCustomer.Remove(product);
           await _context.SaveChangesAsync();
           return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
           return _context.tblCustomer.Any(e => e.CustomerID == id);
        }
    }
}
