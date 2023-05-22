using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
using ResumeSiteWithMvc.repositories;
namespace ResumeSiteWithMvc.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        genericRepository<tblIletisim> repository = new genericRepository<tblIletisim>();

        public ActionResult Index()
        {
            var iletisim = repository.list();
            return View(iletisim);
        }

        public ActionResult mesajSil(int id)
        {
            tblIletisim iletisim = repository.find(i=>i.ıd==id);
            repository.delete(iletisim);
            return RedirectToAction("Index");
        }
    }
}