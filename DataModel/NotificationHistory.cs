using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.DataModel
{
    public class NotificationHistory
    {

            [Display(Name = "Başlık Id")]    
            public string HEADERID { get; set; }
            [Display(Name = "İşlem Yapan")]    
            public string SENDER { get; set; }
            [Display(Name = "İşlem Alıcı")]  
            public string RECEIVER { get; set; }
            [Display(Name = "Doküman Num.")]
            public string WAYBILLNUMBER { get; set; }
        
            [Display(Name = "Doküman Tarihi")]
            public string WAYBILLDATE { get; set; }
        
            [Display(Name = "Başlık Durumu")]
            public string HEADERSTATE { get; set; }
 
            [Display(Name = "İşlem Türü")]
            public string OPERATION { get; set; }
        
            [Display(Name = "Ürün Sayısı")]
            public int DETAILCOUNT { get; set; }

    }
}