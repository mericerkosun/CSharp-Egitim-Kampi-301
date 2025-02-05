using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerDistrict { get; set; }
        public string customerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
