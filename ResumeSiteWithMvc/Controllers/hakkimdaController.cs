using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
using ResumeSiteWithMvc.repositories;
namespace ResumeSiteWithMvc.Controllers
{
    public class hakkimdaController : Controller
    {
        // GET: hakkimda
        genericRepository<tblHakkimda> repository = new genericRepository<tblHakkimda>();
        public ActionResult Index()
        {
            var hakkimda = repository.list();
            return View(hakkimda);
        }
        [HttpGet]
        public ActionResult hakkimdaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult hakkimdaEkle(tblHakkimda p)
        {
            repository.add(p);
            return RedirectToAction("Index");
        }

        public ActionResult hakkimdaSil(int id)
        {
            tblHakkimda hakkimda= repository.find(i=>i.Id==id);
            repository.delete(hakkimda);
            return RedirectToAction("Index");
        }

        public ActionResult hakkimdaGuncellemeSayfasi(int id)
        {
            tblHakkimda hakkimda = repository.find(i => i.Id == id);
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult hakkimdaGuncellemeSayfasi(tblHakkimda p)
        {
            tblHakkimda hakkimda = repository.find(i => i.Id ==p.Id);
            hakkimda.ad = p.ad;
            hakkimda.soyad = p.soyad;
            hakkimda.adres = p.adres;
            hakkimda.telefon = p.telefon;
            hakkimda.mail = p.mail;
            hakkimda.aciklama = p.aciklama;
            hakkimda.fotograf = p.fotograf;
            repository.update(hakkimda);
            return RedirectToAction("Index");
        }
    }
}