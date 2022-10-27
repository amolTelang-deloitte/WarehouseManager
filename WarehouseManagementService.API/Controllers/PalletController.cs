using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalletController : ControllerBase
    {
        private readonly IPalletService _palletService;

        public PalletController(IPalletService palletService)
        {
            _palletService = palletService;
        }
        
        //get all pallets
        [HttpGet("pallet/all")]
        [Authorize(Policy = "Manager")]
        public ActionResult<List<Pallet>> GetAllPallets()
        {
            var pallets=_palletService.GetAllPallets();
            return Ok(pallets);
        }

        //get all products by pallet id
        [HttpGet("pallet/products/{palletId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<List<Product>> GetAllProductByPalletId(long palletId)
        {
            var products = _palletService.GetAllProductsByPalletId(palletId);
            return Ok(products);
        }

        //get pallet details
        [HttpGet("pallet/{palletId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<Pallet>GetPalletDetails(long palletId)
        {
            var pallet = _palletService.GetPalletDetails(palletId);
            return Ok(pallet);
        }

        //get product 
        [HttpGet("product/{palletId:long}/{productId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<Product>GetProduct(long palletId,long productId)
        {
            var product = _palletService.GetProduct(palletId, productId);
            return Ok(product);
        }


        //get product description
        [HttpGet("product/details/{palletId:long}/{productId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<string> GetProductDetails(long palletId, long productId)
        {
            var desc = _palletService.GetProductDetails(palletId, productId);
            return Ok(desc);
        }

        //update pallet details
        [HttpPut("pallet/update/{palletId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<Pallet>UpdatePalletDetails(long palletId,Pallet updatedInfo)
        {
            var pallet = _palletService.UpdatePalletDetails(palletId, updatedInfo);
            return Ok(pallet);

        }





    }
}
