using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57Finance.Model
{
    public class ClientInfo
    {
        public int ID { get; set; } 
        public string ClientCode { get; set; }    
        public string CommercialTitle { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string ClientAccSale { get; set; }
        public string ClientAccBuy { get; set; }
        public int DepartmentID { get; set; }
        public Int64 TaxNo { get; set; }
        public string TaxOffice { get; set; }
        public bool IsBlackListed { get; set; }
        public bool IsActive { get; set; }


    }
}
