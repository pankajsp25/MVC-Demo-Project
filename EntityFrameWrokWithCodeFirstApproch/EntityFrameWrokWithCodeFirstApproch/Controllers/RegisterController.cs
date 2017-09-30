using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWrokWithCodeFirstApproch.Controllers
{
    public class RegisterController : Controller
    {
        private EmployeeDbModel db = new EmployeeDbModel();

        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View(db.Logins.ToList());
        }

        //
        // GET: /Register/Details/5

        public ActionResult Details(string id = null)
        {
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        //
        // GET: /Register/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Register/Create

        [HttpPost]
        public ActionResult Create(Login login)
        {
            if (ModelState.IsValid)
            {
                login.UserId = DateTime.UtcNow.ToString();
                db.Logins.Add(login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(login);
        }

        //
        // GET: /Register/Edit/5

        public ActionResult Edit(string id = null)
        {
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        //
        // POST: /Register/Edit/5

        [HttpPost]
        public ActionResult Edit(Login login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(login);
        }

        //
        // GET: /Register/Delete/5

        public ActionResult Delete(string id = null)
        {
            Login login = db.Logins.Find(id);
            if (login == null)
            {
                return HttpNotFound();
            }
            return View(login);
        }

        //
        // POST: /Register/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Login login = db.Logins.Find(id);
            db.Logins.Remove(login);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}