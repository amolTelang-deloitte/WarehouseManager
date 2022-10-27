using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Application.Repository;
using WarehouseManagementService.Domain.Entities;
using WarehouseManagementService.Infrastructure.Persistence;

namespace WarehouseManagementService.Infrastructure.Repository
{
    public class PalletRepository : IPalletRepository
    {
        private readonly PalletDbContext _dbContext;

        public PalletRepository(PalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Pallet> GetAllPallets()
        {
            return _dbContext.Pallets.ToList();
        }

        public  List<Product> GetAllProductsByPalletId(long PalletId)
        {
            Pallet tempPallet = new Pallet();
            tempPallet =  _dbContext.Pallets.Find(PalletId);
            return tempPallet.Products.ToList();
            
        }

        public Pallet GetPalletDetails(long PalletId)
        {
            Pallet tempPallet = new Pallet();
            tempPallet =  _dbContext.Pallets.Find(PalletId);
            return tempPallet;
        }

        public Product GetProduct(long PalletId, long ProductId)
        { 
            Product tempProduct = new Product();
            tempProduct = _dbContext.Pallets.Find(PalletId).Products.Find(p=>p.ProductId.Equals(ProductId));
            return tempProduct;
            
        }

        public string GetProductDetails(long PalletId, long ProductId)
        {
            Product tempProduct = new Product();
            tempProduct = _dbContext.Pallets.Find(PalletId).Products.Find(p => p.ProductId.Equals(ProductId));
            return tempProduct.ProductDescription;
        }

       

        public Pallet UpdatePalletDetails(long PalletId,Pallet updatedInfo)
        {
            _dbContext.Pallets.Update(updatedInfo);
            return updatedInfo;
        }
    }
}
