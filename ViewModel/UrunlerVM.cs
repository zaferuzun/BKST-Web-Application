using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.ViewModel
{
    public class UrunlerVM
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Seri No alanı boş geçilemez!")]
        [Display(Name = "Seri No")]
        public string Seri_No { get; set; }

        [Required(ErrorMessage = "Parti No alanı boş geçilemez!")]
        [Display(Name = "Parti No")]
        public string Parti_No { get; set; }

        [Required(ErrorMessage = "GTIN No alanı boş geçilemez!")]
        [Display(Name = "GTIN No")]
        public string GTIN_No { get; set; }

        [Required(ErrorMessage = "Üretim Tarihi alanı boş geçilemez!")]
        [Display(Name = "Üretim Tarihi")]
        public string Üretim_Tarihi { get; set; }

        [Required(ErrorMessage = "Son Kullanma Tarihi alanı boş geçilemez!")]
        [Display(Name = "Son Kullanma Tarihi")]
        public string Son_Kullanma_Tarihi { get; set; }

        [Required(ErrorMessage = "Karekod No alanı boş geçilemez!")]
        [Display(Name = "Karekod")]
        public string Karekod_Bilgisi { get; set; }

        [Required(ErrorMessage = "Palet No alanı boş geçilemez!")]
        [Display(Name = "Palet No")]
        public string Palet_No { get; set; }

        [Required(ErrorMessage = "Koli No alanı boş geçilemez!")]
        [Display(Name = "Koli No")]
        public string Koli_No { get; set; }

        [Required(ErrorMessage = "İş Emri No alanı boş geçilemez!")]
        [Display(Name = "İş Emri No")]
        public string İş_Emri_No { get; set; }

        public string Bildirim_Durumu { get; set; }

        public string BildirimValue { get; set; }
        public List<SelectListItem> Bildirim { get; set; }
        public List<SelectListItem> BildirimList()
        {
            List<SelectListItem> myList = new List<SelectListItem>();
            var data = new[]{
                 new SelectListItem{ Value="URETIM",Text="URETIM"},
                 new SelectListItem{ Value="SATIS",Text="SATIS"},
                 new SelectListItem{ Value="SATISIPTAL",Text="SATIS IPTAL"},
                 new SelectListItem{ Value="IADE",Text="IADE"},
                 new SelectListItem{ Value="DEAKTIVASYON",Text="DEAKTIVASYON"},

             };
            myList = data.ToList();
            return myList;
        }
    }
}