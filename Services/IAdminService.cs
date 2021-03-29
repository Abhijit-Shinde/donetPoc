using System;
using System.Threading.Tasks;
using dotnetPoc.ViewModels;
using dotnetPoc.Models;
using System.Collections.Generic;

namespace dotnetPoc.Services
{
    public interface IAdminService
    {
        Task<bool> AddCategory(CategoryViewmodel newCategory);
        Task<IEnumerable<Category>> AllCategory();
        Task<bool> AddProduct(ProductViewModel newProduct, String Path);
        Task<IEnumerable<Shipment>> AllShipments();
        Task<bool> ConfirmOrder(Guid id);
        
    }
}