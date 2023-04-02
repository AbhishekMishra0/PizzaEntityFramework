using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaEntityFramework.DAL
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        public int OrderStatus { get; set; }

        public List<Product> products { get; set; }

    }
}
