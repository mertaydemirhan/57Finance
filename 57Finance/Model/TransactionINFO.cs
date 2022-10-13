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
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public uint DocumentNo { get; set; }
        public int DocumentType { get; set; }
        public string Explanation { get; set; }
        public int DepartmentID { get; set; }
        public int VATRate { get; set; }
        public int PaymentType { get; set; }
        public float ForexAmount { get; set; } 
        public string Forex { get; set; }
        public float Balance { get; set; }
        public float ForexUSD { get; set; }
        public float ForexEUR { get; set; }
        public float ForexGBP { get; set; }
        public float ForexAZN { get; set; }
        public float ForexTL { get; set; }
    }
}
