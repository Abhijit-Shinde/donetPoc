using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetPoc.ViewModels;
using dotnetPoc.Models;

namespace dotnetPoc.Services
{
    public interface IGeneralService
    {
        Task<bool> AddShipment(ShipmentViewModel newShipment);
        Task<IEnumerable<Product>> AllProducts();
        Task<IEnumerable<Product>> AllProductsByIds(IDsViewModel IDs);
        Task<Product> SingleProduct(Guid Id);
    }
}