using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;

namespace OgrenciNotMvc.Controllers
{
    public class SinavController : Controller
    {
        // GET: Sinav
        DbwebprojesiEntities db =new DbwebprojesiEntities(); 
        public ActionResult Index()
        {
            var sinavlar = db.TBLNOTLAR.ToList();
            return View(sinavlar);
        }
        [HttpGet]
        public ActionResult YeniSinav()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult YeniSinav(TBLNOTLAR p)
        {   db.TBLNOTLAR.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}