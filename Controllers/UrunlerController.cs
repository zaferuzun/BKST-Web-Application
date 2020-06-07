using BKSTNewServiceDemoApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Proje1.ViewModel;
using Proje1.WebApi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class UrunlerController : Controller
    {
        private rfwW7SW1qwEntities db = new rfwW7SW1qwEntities();

        // GET: Urunler
        public ActionResult Index()
        {
            var urunler = db.ürünler.ToList();
            List<UrunlerVM> UrunlerList = new List<UrunlerVM>();
            foreach (var item in urunler)
            {
                UrunlerVM urunvm = new UrunlerVM();
                urunvm.Id = item.Id;
                urunvm.Seri_No = item.Seri_No;
                urunvm.Parti_No = item.Parti_No;
                urunvm.GTIN_No = item.GTIN_No;
                urunvm.Üretim_Tarihi = item.Üretim_Tarihi;
                urunvm.Son_Kullanma_Tarihi = item.Son_Kullanma_Tarihi;
                urunvm.Karekod_Bilgisi = item.Karekod_Bilgisi;
                urunvm.Palet_No = item.Palet_No;
                urunvm.Koli_No = item.Koli_No;
                urunvm.İş_Emri_No = item.İş_Emri_No;
                urunvm.Bildirim_Durumu = item.Bildirim_Durumu;
                UrunlerList.Add(urunvm);
            }
            return View(UrunlerList);

        }

        public ActionResult Country()
        {
            CountyResult result = Service.GetCountry();
            string st =result.Message;
            return View();
        }
        public ActionResult Notification()
        {
            //List<Dolar> dolarApi = null;
            ////List<UrunlerVM> dolarApi = new List<UrunlerVM>();

            //WebClient client = new WebClient();
            //var json = client.DownloadString("https://web-paragaranti-pubsub.foreks.com/web-services/securities/exchanges/BIST/groups/E");

            ////var result =  client.GetAsync("https://web-paragaranti-pubsub.foreks.com/web-services/securities/exchanges/BIST/groups/E");
            ////string a = client.Content.ReadAsStringAsync().Result;
            //Dolar.Temperatures di = new Dolar.Temperatures;
            //di = JToken.Parse(json).ToObject<Dolar>();

            //Dolar result = Service.get();
            //string st = result.exchange;
            Service.GetCountry();

            //List<Dolar> dolarApi = new List<Dolar>();
            // dolarApi.Add(account);
            //dolarApi = JsonConvert.DeserializeObject<List<Dolar>>(j);
            //DataContractJsonSerializer jsonSerializer  = new DataContractJsonSerializer(typeof(Dolar));
            //MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData));
            //stream.Position = 0;
            //Dolar dataContractDetail = (Dolar)jsonSerializer.ReadObject(stream);
            //Console.WriteLine(string.Concat("Hi ", dataContractDetail.Email, " " + dataContractDetail.Active));
            //Console.ReadLine();

            //if (dolarApi == null)
            //    return null;
            //foreach(var item in json)
            //{
            //    Dolar urunvm = new Dolar();
            //    urunvm.close = item.close;
            //    urunvm.date = item.date;
            //    urunvm.Parti_No = item.Parti_No;
            //    urunvm.GTIN_No = item.GTIN_No;
            //    urunvm.Üretim_Tarihi = item.Üretim_Tarihi;
            //    urunvm.Son_Kullanma_Tarihi = item.Son_Kullanma_Tarihi;
            //    urunvm.Karekod_Bilgisi = item.Karekod_Bilgisi;
            //    urunvm.Palet_No = item.Palet_No;
            //}
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ürünler urunDB = db.ürünler.Find(id);
            UrunlerVM urunVM = new UrunlerVM();
            urunVM.Id = urunDB.Id;
            urunVM.Seri_No = urunDB.Seri_No;
            urunVM.Parti_No = urunDB.Parti_No;
            urunVM.GTIN_No = urunDB.GTIN_No;
            urunVM.Üretim_Tarihi = urunDB.Üretim_Tarihi;
            urunVM.Son_Kullanma_Tarihi = urunDB.Son_Kullanma_Tarihi;
            urunVM.Karekod_Bilgisi = urunDB.Karekod_Bilgisi;
            urunVM.Palet_No = urunDB.Palet_No;
            urunVM.Koli_No = urunDB.Koli_No;
            urunVM.İş_Emri_No = urunDB.İş_Emri_No;
            urunVM.Bildirim_Durumu = urunDB.Bildirim_Durumu;
            urunVM.Bildirim = urunVM.BildirimList();
            urunVM.Iade = urunVM.IadeList();
            urunVM.Deaktivasyon = urunVM.DeaktivasyonList();

            if (urunDB == null)
            {
                return HttpNotFound();
            }
            return View(urunVM);
        }
        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(UrunlerVM urunVM)
        {

            string value = urunVM.BildirimValue;
            int id = urunVM.Id;
            string vvv = urunVM.Seri_No;
            ürünler urunDB = db.ürünler.Find(id);
            UrunlerVM urunVM2 = new UrunlerVM();
            urunVM2.Id = urunDB.Id;
            urunVM2.Seri_No = urunDB.Seri_No;
            urunVM2.Parti_No = urunDB.Parti_No;
            urunVM2.GTIN_No = urunDB.GTIN_No;
            urunVM2.Üretim_Tarihi = urunDB.Üretim_Tarihi;
            urunVM2.Son_Kullanma_Tarihi = urunDB.Son_Kullanma_Tarihi;
            urunVM2.Karekod_Bilgisi = urunDB.Karekod_Bilgisi;
            urunVM2.Palet_No = urunDB.Palet_No;
            urunVM2.Koli_No = urunDB.Koli_No;
            urunVM2.İş_Emri_No = urunDB.İş_Emri_No;
            DocumentHeader head = new DocumentHeader();
            head.sender = "00000000080";
            //satış için degişti
            head.receiver = "";
            head.key = "9F727065-0758-4152-8B93-06AFA694C7A5";
            //degişti
            head.actionType = "M";
            //döküman numarası ürün idsine göre gönderiliyor.
            head.documentNumber = "1111";
            //head.documentDate = "2018-08-18";
            head.documentDate = DateTime.Now.ToString("yyyy/MM/dd");
            //seçilen bildirime göre degişti
            head.note = "Üretim Bildirimi";
            //deaktivasyon note degiştirildi
            head.deactivationNote = "";
            head.exportReceiverNote = "";
            head.exportCountry = null;
            head.importSenderNote = "";
            head.importCountry = null;
            //iade kodu degiştirildi
            head.returnNote = "";
            head.destructionNote = "";
            head.idTaxNo = "";

            if(value.Equals("DEAKTIVASYON"))
            {
                //action deaktivasyon D
                head.actionType = "D";
                head.note = "DEAKTIVASYON Bildirimi";
                head.deactivationNote = urunVM.DeaktivasyonValue;
            }
            else if(value.Equals("SATIS"))
            {
                //action Satış S
                head.actionType = "S";
                head.receiver = urunVM.aliciGlnNo;
                head.note = "SATIS Bildirimi";
            }
            else if (value.Equals("SATISIPTAL"))
            {
                //action Satış iptal C
                head.actionType = "C";
                head.note = "SATISIPTAL Bildirimi";
            }
            else if (value.Equals("IADE"))
            {
                //action İade R
                head.actionType = "R";
                head.note = "IADE Bildirimi";
                head.returnNote = urunVM.IadeValue;
            }

            string Headaer = Operations.GetJson(head);

            List<DocumentDetail> Deat = new List<DocumentDetail>();
            DocumentDetail detail1 = new DocumentDetail();
            detail1.serialNumber = urunVM2.Seri_No;
            detail1.lotNumber = urunVM2.Parti_No;
            detail1.gtinNumber = urunVM2.GTIN_No;
            detail1.parentCarrierNo = urunVM2.Palet_No;
            detail1.carrierNo = urunVM2.Koli_No;
            detail1.productNote = "ürün açıklaması";
            detail1.productionDate = Convert.ToDateTime(urunVM2.Üretim_Tarihi);
            detail1.expirationDate = Convert.ToDateTime(urunVM2.Son_Kullanma_Tarihi);
            detail1.qrCode = urunVM2.Karekod_Bilgisi;
            Deat.Add(detail1);
            string Detail = Operations.GetJson(Deat);
            JsonResult result = Service.sendNotificationAndDetail("00000000080", "9F727065-0758-4152-8B93-06AFA694C7A5 ", Headaer, Detail);
            return RedirectToAction("Index");
        }

        // GET: Urunler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Urunler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UrunlerVM urunvm)
        {
            if (ModelState.IsValid)
            {
                ürünler üründb = new ürünler();
                üründb.Id = urunvm.Id;
                üründb.Seri_No = urunvm.Seri_No;
                üründb.Parti_No = urunvm.Parti_No;
                üründb.GTIN_No = urunvm.GTIN_No;
                üründb.Üretim_Tarihi = urunvm.Üretim_Tarihi;
                üründb.Son_Kullanma_Tarihi = urunvm.Son_Kullanma_Tarihi;
                üründb.Karekod_Bilgisi = urunvm.Karekod_Bilgisi;
                üründb.Palet_No = urunvm.Palet_No;
                üründb.Koli_No = urunvm.Koli_No;
                üründb.İş_Emri_No = urunvm.İş_Emri_No;
                üründb.Bildirim_Durumu = null;
                db.ürünler.Add(üründb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(urunvm);
        }

        // GET: Urunler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ürünler urunDB = db.ürünler.Find(id);
            UrunlerVM urunVM = new UrunlerVM();
            urunVM.Id = urunDB.Id;
            urunVM.Seri_No = urunDB.Seri_No;
            urunVM.Parti_No = urunDB.Parti_No;
            urunVM.GTIN_No = urunDB.GTIN_No;
            urunVM.Üretim_Tarihi = urunDB.Üretim_Tarihi;
            urunVM.Son_Kullanma_Tarihi = urunDB.Son_Kullanma_Tarihi;
            urunVM.Karekod_Bilgisi = urunDB.Karekod_Bilgisi;
            urunVM.Palet_No = urunDB.Palet_No;
            urunVM.Koli_No = urunDB.Koli_No;
            urunVM.İş_Emri_No = urunDB.İş_Emri_No;

            if (urunDB == null)
            {
                return HttpNotFound();
            }
            return View(urunVM);
        }

        // POST: Urunler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UrunlerVM  urunVM)
        {
            if (ModelState.IsValid)
            {
                ürünler ürünDB = new ürünler();
                ürünDB.Id = urunVM.Id;
                ürünDB.Seri_No = urunVM.Seri_No;
                ürünDB.Parti_No = urunVM.Parti_No;
                ürünDB.GTIN_No = urunVM.GTIN_No;
                ürünDB.Üretim_Tarihi = urunVM.Üretim_Tarihi;
                ürünDB.Son_Kullanma_Tarihi = urunVM.Son_Kullanma_Tarihi;
                ürünDB.Karekod_Bilgisi = urunVM.Karekod_Bilgisi;
                ürünDB.Palet_No = urunVM.Palet_No;
                ürünDB.Koli_No = urunVM.Koli_No;
                ürünDB.İş_Emri_No = urunVM.İş_Emri_No;

                db.Entry(ürünDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(urunVM);
        }

        // GET: Urunler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ürünler urunDB = db.ürünler.Find(id);
            UrunlerVM urunVM = new UrunlerVM();
            urunVM.Id = urunDB.Id;
            urunVM.Seri_No = urunDB.Seri_No;
            urunVM.Parti_No = urunDB.Parti_No;
            urunVM.GTIN_No = urunDB.GTIN_No;
            urunVM.Üretim_Tarihi = urunDB.Üretim_Tarihi;
            urunVM.Son_Kullanma_Tarihi = urunDB.Son_Kullanma_Tarihi;
            urunVM.Karekod_Bilgisi = urunDB.Karekod_Bilgisi;
            urunVM.Palet_No = urunDB.Palet_No;
            urunVM.Koli_No = urunDB.Koli_No;
            urunVM.İş_Emri_No = urunDB.İş_Emri_No;
            urunVM.Bildirim_Durumu = urunDB.Bildirim_Durumu;

            if (urunVM == null)
            {
                return HttpNotFound();
            }
            return View(urunVM);
        }



        // POST: Urunler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ürünler ürünler = db.ürünler.Find(id);
            db.ürünler.Remove(ürünler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
