using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class TransactionINFO
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public double Amount { get; set; }
        public string ClientCommercialTitle { get; set; }
        public string ClientCode { get; set; }
        public DateTime Date { get; set; }
        public uint DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public string Explanation { get; set; }
        public int DepartmentID { get; set; }
        public int VATRate { get; set; }
        public int PaymentType { get; set; }
        public double ForexAmount { get; set; } 
        public string Forex { get; set; }
        public double Balance { get; set; }
        public double ForexUSD { get; set; }
        public double ForexEUR { get; set; }
        public double ForexGBP { get; set; }
        public double ForexAZN { get; set; }
        public double ForexTL { get; set; }
    }
}
