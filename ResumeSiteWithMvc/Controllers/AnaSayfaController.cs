using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
namespace ResumeSiteWithMvc.Controllers
{
    [AllowAnonymous]
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        ViewModel ViewModel = new ViewModel();
        resumeEntities1 db = new resumeEntities1();
        public ActionResult Index()
        {
            var hakkimda = db.tblHakkimda.ToList();
            return View(hakkimda);
        }
        public PartialViewResult socialMedia()
        {
            var socialMediaHesaplari = db.tblSocialMedia.ToList();
            return PartialView(socialMediaHesaplari);
        }
        public PartialViewResult deneyimlerim()
        {
            var deneyimlerim = db.tblDeneyimlerim.ToList();
            return PartialView(deneyimlerim);
        }

        public PartialViewResult egitimlerim()
        {
            var egitimlerim = db.tblEğitimleri.ToList();
            return PartialView(egitimlerim);
        }
        public PartialViewResult yetkinliklerim()
        {
            //var yetkinlikler = db.tblYetkinliklerim.ToList();
            //return PartialView(yetkinlikler);
            List<tblProgramlamaDilleri> programlamaDilleri =db.tblProgramlamaDilleri.ToList();
            ViewModel.programlamaDilleri = programlamaDilleri;

            List<tblFramework> Frameworkler= db.tblFramework.ToList();
            ViewModel.frameworkler = Frameworkler;

            List<tblVeriTabani> veriTabani= db.tblVeriTabani.ToList();
            ViewModel.VeriTabaniYonetimSistemleri = veriTabani;

            List<tblIde> Ide= db.tblIde.ToList();
            ViewModel.Ideler = Ide;

            return PartialView(ViewModel);
        }

        public PartialViewResult hobilerim()
        {
            var hobilerim = db.tblHobilerim.ToList();
            return PartialView(hobilerim);
        }

        public PartialViewResult projeler()
        {
            var projeler = db.tblProjeler.ToList();
            return PartialView(projeler);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(tblIletisim p)
        {
            db.tblIletisim.Add(p);
            db.SaveChanges();
            return PartialView();
        }
    }
}