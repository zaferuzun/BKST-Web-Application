using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        // GET: Urunler/Details/5
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
            if (urunDB == null)
            {
                return HttpNotFound();
            }
            return View(urunVM);
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
                üründb.Bildirim_Durumu = urunvm.Bildirim_Durumu;
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
            urunVM.Bildirim_Durumu = urunDB.Bildirim_Durumu;
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
                ürünDB.Bildirim_Durumu = urunVM.Bildirim_Durumu;
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
