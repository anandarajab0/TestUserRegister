using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotNetAppSqlDb.Models;using System.Diagnostics;

namespace DotNetAppSqlDb.Controllers
{
    public class RegistrationController : Controller
    {
        private MyDatabaseContext db = new MyDatabaseContext();

        // GET: Registration
        public ActionResult Index()
        {            
         //   Trace.WriteLine("GET /Registration/Index");
            return View(db.UserRegister.ToList());
        }

        // GET: Registration/Create
        public ActionResult Create()
        {

             //  Trace.WriteLine("GET /Registration/Create");
            //   return View(new UserRegistration { CreatedDate = DateTime.Now });
        
            
            //return View();
           return View(new UserRegistration { CreatedDate = DateTime.Now });
        }

        

        // POST: Registration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Description,CreatedDate,Gender,Email,SelectedDays,AddRequest")] UserRegistration userRegistration)
        {
            Trace.WriteLine("POST /Registration/Create");
            if (ModelState.IsValid)
            {
                db.UserRegister.Add(userRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userRegistration);
        }

      

     
 

    }
}
