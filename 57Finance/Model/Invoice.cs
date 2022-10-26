using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public int InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDetails { get; set; }
        public int VATRate { get; set; }
        public double Amount { get; set; }
        public string Forex { get; set; }
        public double ForexAmount { get; set; } 
        public int ClientID { get; set; }
        public double AmountWithVAT { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAmountForex { get; set; }
        public double VATBasis { get; set; }

    }
}
