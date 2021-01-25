using LaundrySystem.UI.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Services
{
    public class ServiceRepo : IServiceRepo
    {
        private LaundrydbContext _context;

        public ServiceRepo()
        {
            _context = new LaundrydbContext();
        }

        //public async Task AddServiceAsync(tblService model)
        //{
        //    await _context.tblService.AddAsync(model);
        //}

        //public void Commit()
        //{
        //    _context.SaveChanges();
        //}

        //public async Task DeleteServiceAsync(tblService entity)
        //{
        //    var idT = await _context.tblService.FindAsync(entity.ServiceId);
        //    _context.tblService.Remove(idT);
        //    //await _context.SaveChangesAsync();
        //}

        public IEnumerable<SelectListItem> GetAllServices()
        {
            var obj = new List<SelectListItem>();
            obj = (from p in _context.tblService
                   select new SelectListItem()
                   {
                       Text = p.ServiceName,
                       Value = p.ServiceId.ToString(),
                       Selected = true
                   }).ToList();

            return obj;
        }

        //public async Task<IEnumerable<tblService>> GetAllServicesAsync()
        //{
        //    return await _context.tblService.ToListAsync();
        //}

        //public tblService GetService(Guid ServiceID)
        //{
        //    return _context.tblService.FirstOrDefault(c => c.ServiceId == ServiceID);
        //}

        //public async Task<IEnumerable<tblService>> GetServicesAsync()
        //{
        //    var query = from s in _context.tblService
        //                join a in _context.AspNetUsers
        //                on s.CreatedBy equals a.Id
        //                select new
        //                {
        //                    s.ServiceId,
        //                    s.ServiceName,
        //                    s.ServiceImage,
        //                    s.AddedDate,
        //                    s.CreatedBy,
        //                    a.Id,
        //                    //a.FirstName + a.LastName
        //                };
        //    //throw new NotImplementedException();
        //}

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public async Task UpdateServiceAsync(tblService model)
        {
            var data = new tblService
            {
                ServiceId = model.ServiceId,
                ServiceName = model.ServiceName,
                ServiceImage = model.ServiceImage,
                AddedDate = DateTime.UtcNow,
                CreatedBy = model.CreatedBy
            };

            _context.Update(data);
            await _context.SaveChangesAsync();

            //await _context.tblService.FindAsync(model.ServiceId);
            //_context.tblService.Update(model);
        }
    }
}
