using LaundrySystem.UI.Entities;
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

        public ServiceRepo(LaundrydbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddServiceAsync(tblService model)
        {
            await _context.tblService.AddAsync(model);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task DeleteServiceAsync(tblService entity)
        {
            var idT = await _context.tblService.FindAsync(entity.ServiceId);
            _context.tblService.Remove(idT);
            //await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<tblService>> GetAllServicesAsync()
        {
            return await _context.tblService.ToListAsync();
        }

        public tblService GetService(Guid ServiceID)
        {
            return _context.tblService.FirstOrDefault(c => c.ServiceId == ServiceID);
        }

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
