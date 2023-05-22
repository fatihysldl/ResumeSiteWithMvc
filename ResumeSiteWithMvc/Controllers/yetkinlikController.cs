using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeSiteWithMvc.Models.entity;
using ResumeSiteWithMvc.repositories;
namespace ResumeSiteWithMvc.Controllers
{
    public class yetkinlikController : Controller
    {
        genericRepository<tblProgramlamaDilleri> programRepo = new genericRepository<tblProgramlamaDilleri>();
        genericRepository<tblVeriTabani> veriTabaniRepo = new genericRepository<tblVeriTabani>();
        genericRepository<tblIde> ıdeRepo = new genericRepository<tblIde>();
        genericRepository<tblFramework> frameworkRepo = new genericRepository<tblFramework>();
        // GET: yetkinlik


        //TABLOLARIN LİSTELENDİĞİ ALAN-- BURADA BİRDEN FAZLA TABLO KULLANILDIĞI İÇİN View Model adında bir sınıfta tablolar tutulup buradan çağırılıyor
        public ActionResult Index()
        {
            //var yetkinlik = repository.list();
            //return View(yetkinlik);
            var programlama = programRepo.list();
            var veriTabaniSistemleri = veriTabaniRepo.list();
            var ideler = ıdeRepo.list();
            var framework = frameworkRepo.list();
            
            var viewModel = new ViewModel
            {
                programlamaDilleri = programlama,
                VeriTabaniYonetimSistemleri= veriTabaniSistemleri,
                frameworkler = framework,
                Ideler= ideler
            };         
            return View(viewModel);
        }

        //PROGRAMLAMA DİLLERİ ALANI
        [HttpGet]
        public ActionResult programlamaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult programlamaEkle(tblProgramlamaDilleri p)
        {
            programRepo.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult programlamaSil(int id)
        {
            tblProgramlamaDilleri programlama = programRepo.find(i => i.ıd == id);
            programRepo.delete(programlama);
            return RedirectToAction("Index");
        }
        public ActionResult programlamaGuncellemeSayfasi(int id)
        {
            tblProgramlamaDilleri programlama = programRepo.find(i => i.ıd == id);
            return View(programlama);
        }
        [HttpPost]
        public ActionResult programlamaGuncellemeSayfasi(tblProgramlamaDilleri p)
        {
            tblProgramlamaDilleri programlama = programRepo.find(i => i.ıd == p.ıd);
            programlama.programlamaDilleri = p.programlamaDilleri;
            programRepo.update(programlama);
            return RedirectToAction("Index");
        }

        //VERİ TABANI YÖNETİM SİSTEMLERİ ALANI

        [HttpGet]
        public ActionResult veriTabaniEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult veriTabaniEkle(tblVeriTabani p)
        {
            veriTabaniRepo.add(p);
            return RedirectToAction("Index");
        }

        public ActionResult veriTabaniSil(int id)
        {
            tblVeriTabani veriTabani = veriTabaniRepo.find(i => i.id == id);
            veriTabaniRepo.delete(veriTabani);
            return RedirectToAction("Index");
        }

        public ActionResult veriTabaniGuncellemeSayfasi(int id)
        {
            tblVeriTabani veriTabani = veriTabaniRepo.find(i => i.id == id);
            return View(veriTabani);
        }
        [HttpPost]
        public ActionResult veriTabaniGuncellemeSayfasi(tblVeriTabani p)
        {
            tblVeriTabani veriTabani = veriTabaniRepo.find(i => i.id == p.id);
            veriTabani.VeriTabanıSistemi = p.VeriTabanıSistemi;
            veriTabaniRepo.update(veriTabani);
            return RedirectToAction("Index");
        }


        //DENEYİMLEDİĞİM IDELER ALANI
        [HttpGet]
        public ActionResult ıdeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ıdeEkle(tblIde p)
        {
            ıdeRepo.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult ıdeSil(int id)
        {
            tblIde ıde = ıdeRepo.find(i => i.id == id);
            ıdeRepo.delete(ıde);
            return RedirectToAction("Index");
        }

        public ActionResult ıdeGuncellemeSayfasi(int id)
        {
            tblIde ıde = ıdeRepo.find(i => i.id == id);
            return View(ıde);
        }
        [HttpPost]
        public ActionResult ıdeGuncellemeSayfasi(tblIde p)
        {
            tblIde ıde = ıdeRepo.find(i => i.id == p.id);
            ıde.ide = p.ide;
            ıdeRepo.update(ıde);
            return RedirectToAction("Index");
        }

        //DENEYİMLEDİĞİM FRAMEWORKLER ALANI
        [HttpGet]
        public ActionResult frameworkEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult frameworkEkle(tblFramework p)
        {
            frameworkRepo.add(p);
            return RedirectToAction("Index");
        }
        public ActionResult frameworkSil(int id)
        {
            tblFramework framework = frameworkRepo.find(i => i.id == id);
            frameworkRepo.delete(framework);
            return RedirectToAction("Index");
        }

        public ActionResult frameworkGuncellemeSayfasi(int id)
        {
            tblFramework framework = frameworkRepo.find(i => i.id == id);
            return View(framework);
        }
        [HttpPost]
        public ActionResult frameworkGuncellemeSayfasi(tblFramework p)
        {
            tblFramework framework = frameworkRepo.find(i => i.id == p.id);
            framework.framework = p.framework;
            frameworkRepo.update(framework);
            return RedirectToAction("Index");
        }



    }
}