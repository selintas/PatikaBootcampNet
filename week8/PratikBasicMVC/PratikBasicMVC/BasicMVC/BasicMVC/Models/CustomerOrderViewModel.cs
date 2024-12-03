using System.Collections.Generic;

namespace BasicMVC.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }  // Müşteri bilgileri
        public List<Order> Orders { get; set; }  // Siparişlerin listesi
    }
}
