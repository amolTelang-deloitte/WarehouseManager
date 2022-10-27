using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementService.Domain.Entities
{
    public class Order
    {
        public  long OrderId { get; set; }

        public  long CustomerId { get; set; }

        public List<Product> OrderedProducts { get; set; }

        public string Status { get; set; }

        public DateTime OrderedAt { get; set; } = DateTime.Now;
    }
}
