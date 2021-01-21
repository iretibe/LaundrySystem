using LaundrySystem.UI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Services
{
    public interface IServiceRepo
    {
        Task<IEnumerable<tblService>> GetAllServicesAsync();
        //Task<IEnumerable<tblService>> GetServicesAsync();
        Task DeleteServiceAsync(tblService entity);
        tblService GetService(Guid ServiceID);
        Task AddServiceAsync(tblService model);
        Task UpdateServiceAsync(tblService model);
        bool Save();
        void Commit();
    }
}
