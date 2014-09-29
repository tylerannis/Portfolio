using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Potfolio.Controllers
{
    public class ContactController : Controller
    {
        Models.TylerEntities db = new Models.TylerEntities();
        
        //
        // GET: /Contact/

     

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Comment());
        }

        [HttpPost]
        public ActionResult Index(Models.Comment contactForm)
        {
            //tell the DB context that the contact form needs to be updated
            db.Comments.Add(contactForm);
            //save changes
            db.SaveChanges();
            //kick user back to list

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Thanks()
        {
            return View();
           
        }
       
        
    }
}
