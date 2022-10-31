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
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public string Forex { get; set; }
        public decimal ForexRateBuy { get; set; }
        public decimal ForexRateSell { get; set; }
        public decimal FPrice { get; set; }
        public decimal PriceTotal { get; set; }

    }
}
