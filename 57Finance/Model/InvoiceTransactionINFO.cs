using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class InvoiceTransactionINFO
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public string Forex { get; set; }
        public double ForexRateBuy { get; set; }
        public double ForexRateSell { get; set; }
        public double FPrice { get; set; }
        public double PriceTotal { get; set; }

    }
}
