using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class ServiceInfo
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public double Price { get; set; }
        public double VATRate {get; set;}
        public string Comment { get; set; }
        public string ServiceAccSale { get; set; }
        public string ServiceAccBuy { get; set; }
        public double FPrice { get; set; }
        public string Forex { get; set; }

    }
}
