using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
using ResumeSiteWithMvc.repositories;
namespace ResumeSiteWithMvc.Controllers
{
    public class sosyalMedyaController : Controller
    {
        // GET: sosyalMedya
        genericRepository<tblSocialMedia> repository = new genericRepository<tblSocialMedia>();
        public ActionResult Index()
        {
            var sosyalMedya = repository.list();
            return View(sosyalMedya);
        }
        [HttpGet]
        public ActionResult sosyalMedyaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult sosyalMedyaEkle(tblSocialMedia p)
        {

            repository.add(p);
            return RedirectToAction("Index");
        }

        public ActionResult sosyalMedyaSil(int id)
        {
            var sosyalMedya = repository.find(i => i.id==id);
            repository.delete(sosyalMedya);
            return RedirectToAction("Index");
        }

        public ActionResult sosyalMedyaGuncellemeSayfasi(int id)
        {
            tblSocialMedia sosyalMedya = repository.find(i => i.id == id);
            return View(sosyalMedya);
        }
        [HttpPost]
        public ActionResult sosyalMedyaGuncellemeSayfasi(tblSocialMedia p)
        {
            tblSocialMedia sosyalMedya = repository.find(i => i.id == p.id);
            sosyalMedya.sosyalMedyaAd = p.sosyalMedyaAd;
            sosyalMedya.sosyalMedyaLink = p.sosyalMedyaLink;
            sosyalMedya.iconLink = p.iconLink;
            repository.update(sosyalMedya);
            return RedirectToAction("Index");
        }
    }
}