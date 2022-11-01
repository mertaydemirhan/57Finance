using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class Invoice
    {
        public int ClientID { get; set; }
        public int InvoiceID { get; set; }
        public string ClientCode { get; set; }
        public string ClientCommercialTitle { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDetails { get; set; }
        public decimal VATRate { get; set; }
        public decimal Amount { get; set; }
        public string DepartmentName { get; set; }
        public decimal VATBasis { get; set; }
        public decimal AmountWithVAT { get; set; }
        public decimal TotalAmount { get; set; }
        public string Forex { get; set; }
        public decimal ForexAmount { get; set; } 
        public decimal TotalAmountForex { get; set; }
        public string TaxNo { get; set; }
        public string TaxOffice { get; set; }
        public decimal VAT { get; set; }
       

    }
}
