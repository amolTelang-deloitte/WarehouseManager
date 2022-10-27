using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Application.Repository;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Application.Services
{
    public class PalletServices : IPalletService
    {
        private readonly IPalletRepository _palletRepository;

        public PalletServices(IPalletRepository palletRepository)
        {
            _palletRepository = palletRepository;
        }

        public List<Pallet> GetAllPallets()
        {
            var pallets = _palletRepository.GetAllPallets();
            return pallets;
        }

        public List<Product> GetAllProductsByPalletId(long PalletId)
        {
            var products = _palletRepository.GetAllProductsByPalletId(PalletId);
            return products;
        }

        public Pallet GetPalletDetails(long PalletId)
        {
            var pallet=_palletRepository.GetPalletDetails(PalletId);
            return pallet;
        }

        public Product GetProduct(long PalletId, long ProductId)
        {
            var product=_palletRepository.GetProduct(PalletId, ProductId);
            return product;
        }

        public string GetProductDetails(long PalletId, long ProductId)
        {
            var details=_palletRepository.GetProductDetails(PalletId, ProductId);
            return details;
        }

        public Pallet UpdatePalletDetails(long PalletId, Product updatedInfo)
        {
           var pallet=_palletRepository.UpdatePalletDetails(PalletId, updatedInfo);
            return pallet;
        }
    }
}
