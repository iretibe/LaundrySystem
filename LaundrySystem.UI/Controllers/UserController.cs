using LaundrySystem.UI.Entities;
using LaundrySystem.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Controllers
{
    public class UserController : Controller
    {
        private LaundrydbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(LaundrydbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.AspNetUsers.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);

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
        public async Task<IActionResult> Create( AspNetUsers product)
        {
            //if (ModelState.IsValid)
            //{
            //    //product.Id = string.Empty;
            //    _context.Add(product);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Edit), new { id = product.Id });
            //}
            //return View(product);

            var appUser = new ApplicationUser()
            {
                UserName = product.UserName,
                Email = product.Email,
                PhoneNumber = product.PhoneNumber,
                FirstName = product.FirstName,
                LastName = product.LastName,
                Address = product.Address,
                City = product.City
            };

            try
            {
                IdentityResult result = await _userManager.CreateAsync(appUser, product.PasswordHash);

                if (result.Succeeded)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("GivenName", appUser.UserName),
                        new Claim("FamilyName", appUser.FirstName + " " + appUser.LastName),
                        new Claim("WebSite", appUser.Id),
                        new Claim("Email", appUser.Email),
                        new Claim("PhoneNumber", appUser.PhoneNumber)
                    };

                    await _userManager.AddClaimsAsync(appUser, claims);

                    //return RedirectToAction(nameof(Index));
                }
                else
                {
                    return BadRequest();
                }

                //return View(product);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.AspNetUsers.FindAsync(id);
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
        public async Task<IActionResult> Edit(string id, [Bind("Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount,FirstName,LastName,Address,City,IsAdmin,Picture,DateAdded")] AspNetUsers product)
        {
            if (id != product.Id)
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
                    if (!ProductExists(product.Id))
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
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.AspNetUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _context.AspNetUsers.FindAsync(id);
            _context.AspNetUsers.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}
