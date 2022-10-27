using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementService.Domain.Entities
{
    public class Pallet
    {
        public new long PalletId { get; set; }
        public string PalletName { get; set; }
        public int ProductQuantity{ get; set; }
        public List<Product> Products { get; set; }
    }
}
