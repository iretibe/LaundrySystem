using AutoMapper;
using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class ServiceController : Controller
    {
        //private readonly IServiceRepo _serviceRepo;
        //private readonly IMapper _mapper;
        private LaundrydbContext _context;

        public ServiceController(LaundrydbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.tblService.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.tblService.FirstOrDefaultAsync(m => m.ServiceId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ServiceName,ServiceImage,AddedDate,CreatedBy")] tblService products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.tblService.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ServiceId,ServiceName,ServiceImage,AddedDate,CreatedBy")] tblService products)
        {
            if (id != products.ServiceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.ServiceId))
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
            return View(products);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.tblService.FirstOrDefaultAsync(m => m.ServiceId == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            var products = await _context.tblService.FindAsync(id);
            _context.tblService.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(Guid id)
        {
            return _context.tblService.Any(e => e.ServiceId == id);
        }

        //http://www.mukeshkumar.net/articles/dotnetcore/crud-operation-in-asp-net-core-web-api-with-entity-framework-core
    }
}
