using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.ViewModel
{
    public class UrunlerVM
    {
        public int Id { get; set; }
        public string Seri_No { get; set; }
        public string Parti_No { get; set; }
        public string GTIN_No { get; set; }
        public string Üretim_Tarihi { get; set; }
        public string Son_Kullanma_Tarihi { get; set; }
        public string Karekod_Bilgisi { get; set; }
        public string Palet_No { get; set; }
        public string Koli_No { get; set; }
        public string İş_Emri_No { get; set; }
        public string Bildirim_Durumu { get; set; }
    }
}