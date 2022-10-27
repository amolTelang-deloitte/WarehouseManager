using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Application.Interface
{
    public interface IPalletService
    {
        //get all pallets
        List<Pallet> GetAllPallets();

        //get all products that belong to a pallet
        List<Product> GetAllProductsByPalletId(long PalletId);

        //get pallet by palletId
        Pallet GetPalletDetails(long PalletId);

        //get specific product that belong to a pallet
        Product GetProduct(long PalletId, long ProductId);

        //get a specific product description
        string GetProductDetails(long PalletId, long ProductId);

        //update Pallet details
        Pallet UpdatePalletDetails(long PalletId, Pallet updatedInfo);
    }
}
