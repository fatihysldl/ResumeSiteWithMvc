using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.repositories;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.Controllers
{
    public class egitimController : Controller
    {
        genericRepository<tblEğitimleri> repository = new genericRepository<tblEğitimleri>();
        // GET: egitim
        public ActionResult Index()
        {
            var egitimlerim = repository.list();
            return View(egitimlerim);
        }
        [HttpGet]
        public ActionResult egitimEkle()
        {
            return View();
        }
        public ActionResult egitimEkle(tblEğitimleri p)
        {
            repository.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult egitimSil(int id)
        {
            tblEğitimleri egitim = repository.find(i => i.ıd == id);
            repository.delete(egitim);
            return RedirectToAction("Index");
        }
        public ActionResult egitimGuncellemeSayfasi(int id)
        {
            tblEğitimleri egitim = repository.find(i => i.ıd == id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult egitimGuncellemeSayfasi(tblEğitimleri p)
        {
            tblEğitimleri egitim = repository.find(i => i.ıd == p.ıd);
            egitim.baslik = p.baslik;
            egitim.altBaslik = p.altBaslik;
            egitim.altBaslik1 = p.altBaslik1;
            egitim.notOrtalamasi = p.notOrtalamasi;
            egitim.tarih = p.tarih;
            repository.update(egitim);
            return RedirectToAction("Index");
        }
    }
}