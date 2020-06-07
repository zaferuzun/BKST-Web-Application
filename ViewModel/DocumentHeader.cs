using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje1.ViewModel
{
    public class DocumentHeader
    {
        public string sender { get; set; }
        public string receiver { get; set; }
        public string key { get; set; }
        public string actionType { get; set; }
        public string documentNumber { get; set; }
        public string documentDate { get; set; }
        public string note { get; set; }
        public string deactivationNote { get; set; }
        public string exportReceiverNote { get; set; }
        public string exportCountry { get; set; }
        public string importSenderNote { get; set; }
        public string importCountry { get; set; }
        public string returnNote { get; set; }
        public string destructionNote { get; set; }
        public string idTaxNo { get; set; }
    }

}