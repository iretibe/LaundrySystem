using LaundrySystem.UI.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaundrySystem.UI.Services
{
    public interface IServiceRepo
    {
        IEnumerable<SelectListItem> GetAllServices();
        ////Task<IEnumerable<tblService>> GetServicesAsync();
        //Task DeleteServiceAsync(tblService entity);
        //tblService GetService(Guid ServiceID);
        //Task AddServiceAsync(tblService model);
        //Task UpdateServiceAsync(tblService model);
        //bool Save();
        //void Commit();
    }
}
