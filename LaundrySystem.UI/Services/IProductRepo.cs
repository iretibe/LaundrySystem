using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LaundrySystem.UI.Services
{
    public interface IProductRepo
    {
        IEnumerable<SelectListItem> GetAllProducts();
    }
}
