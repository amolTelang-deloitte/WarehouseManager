using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementService.Domain.Entities
{
    public class Product
    {
        public string ProductId { get; set; }
        public string WarehouseId { get; set; }
        public string ProductName { get; set; }
        public int PricePerItem { get; set; }
        public string ProductDescription { get; set; }
    }
}
