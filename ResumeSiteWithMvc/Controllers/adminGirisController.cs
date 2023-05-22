using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ResumeSiteWithMvc.Models.entity;

namespace ResumeSiteWithMvc.Controllers
{
    [AllowAnonymous]
    public class adminGirisController : Controller
    {

        // GET: adminGiris
        resumeEntities1 db = new resumeEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult girisYap(tblAdminGiris p)
        {

            var adminBilgileri = db.tblAdminGiris.FirstOrDefault(x => x.adminKullaniciAdi == p.adminKullaniciAdi && x.adminSifre == p.adminSifre);
            if (adminBilgileri != null)
            {
                FormsAuthentication.SetAuthCookie(adminBilgileri.adminKullaniciAdi, false);
                Session["adminKullaniciAdi"] = adminBilgileri.adminKullaniciAdi.ToString();
                return RedirectToAction("Index", "adminPanelAnasayfa");
            }
            else
            {
                ModelState.AddModelError("","Lütfen kullanıcı adı ve şifrenizi kontrol edin.");
                return View("Index", p);

            }
        }
    }
}