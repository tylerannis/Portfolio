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

        public ActionResult Index()
        {
            return View(db.Comments);
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            return View(db.Comments.Find(ID));
        }

        [HttpPost]
        public ActionResult Edit(int ID, Models.Comment contactForm)
        {
            //tell the DB context that the contact form needs to be updated
            db.Entry(contactForm).State = System.Data.EntityState.Modified;
            //save changes
            db.SaveChanges();
            //kick user back to list

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Delete(int id)
        {
            return View(db.Comments.Find(id));
        }

        public ActionResult DeleteConfirm(int ID)
        {
            //get the form to delet from the database
            Models.Comment formToDelete = db.Comments.Find(ID);
            //remove from formtoDelete
            db.Comments.Remove(formToDelete);

            db.SaveChanges();
            //kick them back to the list
            return RedirectToAction("Index", "Home");
        }
        
    }
}
