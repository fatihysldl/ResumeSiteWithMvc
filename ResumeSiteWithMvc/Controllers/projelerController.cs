using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
using ResumeSiteWithMvc.repositories;
namespace ResumeSiteWithMvc.Controllers
{
    public class projelerController : Controller
    {
        // GET: projeler
        genericRepository<tblProjeler> repository = new genericRepository<tblProjeler>();
        public ActionResult Index()
        {
            var projeler = repository.list();
            return View(projeler);
        }
        [HttpGet]
        public ActionResult projeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult projeEkle(tblProjeler p)
        {
            repository.add(p);
            return RedirectToAction("Index");
        }

        public ActionResult projeSil(int id)
        {
            tblProjeler proje = repository.find(i => i.id == id);
            repository.delete(proje);
            return RedirectToAction("Index");
        }

        public ActionResult projeGuncellemeSayfasi(int id)
        {
            tblProjeler proje = repository.find(i => i.id == id);
            return View(proje);
        }
        [HttpPost]
        public ActionResult projeGuncellemeSayfasi(tblProjeler p)
        {
            tblProjeler proje = repository.find(i => i.id == p.id);
            proje.Proje = p.Proje;
            repository.update(proje);
            return RedirectToAction("Index");
        }
    }
}