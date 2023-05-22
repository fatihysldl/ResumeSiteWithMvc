using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.repositories;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.Controllers
{
    public class deneyimController : Controller
    {
        // GET: deneyim
        DeneyimRepository repository = new DeneyimRepository();
        public ActionResult Index()
        {
            var deneyimler = repository.list();
            return View(deneyimler);
        }
        [HttpGet]
        public ActionResult deneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deneyimEkle(tblDeneyimlerim p)
        {
            repository.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult deneyimSil(int id)
        {
            tblDeneyimlerim deneyim = repository.find(i => i.ıd == id);
            repository.delete(deneyim);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult deneyimGuncellemeSayfasi(int id)
        {
            tblDeneyimlerim deneyim = repository.find(i => i.ıd == id);
            return View(deneyim);
        }
        [HttpPost]
        public ActionResult deneyimGuncellemeSayfasi(tblDeneyimlerim p)
        {
            tblDeneyimlerim deneyim = repository.find(i => i.ıd == p.ıd);
            deneyim.baslik = p.baslik;
            deneyim.altBaslik = p.altBaslik;
            deneyim.aciklama = p.aciklama;
            deneyim.tarih = p.tarih;
            repository.update(deneyim);
            return RedirectToAction("Index");
        }
    }
}