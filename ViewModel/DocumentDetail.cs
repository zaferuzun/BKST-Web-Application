using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje1.ViewModel
{
    public class DocumentDetail
    {

        public string serialNumber { get; set; }
        public string lotNumber { get; set; }
        public string gtinNumber { get; set; }
        public string parentCarrierNo { get; set; }
        public string carrierNo { get; set; }
        public string productNote { get; set; }
        public DateTime? productionDate { get; set; }
        public DateTime? expirationDate { get; set; }
        public string qrCode { get; set; }
    }
}