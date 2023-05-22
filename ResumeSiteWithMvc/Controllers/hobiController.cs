using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.repositories;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.Controllers
{
    public class hobiController : Controller
    {
        // GET: hobi
        genericRepository<tblHobilerim> repository = new genericRepository<tblHobilerim>();
        public ActionResult Index()
        {
            var hobilerim = repository.list();
            return View(hobilerim);
        }
        [HttpGet]
        public ActionResult hobiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult hobiEkle(tblHobilerim p)
        {

            repository.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult hobiSil(int id)
        {
            tblHobilerim hobi = repository.find(i => i.ıd == id);
            repository.delete(hobi);
            return RedirectToAction("Index");
        }
        public ActionResult hobiGuncellemeSayfasi(int id)
        {
            tblHobilerim hobi = repository.find(i => i.ıd == id);
            return View(hobi);
        }
        [HttpPost]
        public ActionResult hobiGuncellemeSayfasi(tblHobilerim p)
        {
            tblHobilerim hobi = repository.find(i => i.ıd == p.ıd);
            hobi.hobi = p.hobi;
            repository.update(hobi);
            return RedirectToAction("Index");
        }
    }
}