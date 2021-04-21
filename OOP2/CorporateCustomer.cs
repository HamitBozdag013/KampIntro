using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{   // Tüzel Müşteri Sınıfı
    class CorporateCustomer : Customer //Inheritance
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; } //TaxNumer --> VergiNo
    }
}
