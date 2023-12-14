using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1_alter_.Controllers
{
    public class NameController : Controller
    {
        NameEntities db=new NameEntities();
        // GET: Name
        [HttpGet]
        public ActionResult Index(int ? id)
        {
            Name name = new Name();
            return View(name);
        }
        [HttpPost]
        public ActionResult Index(Name name)
        {
            try 
            {


                db.Names.Add(name);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.SuccessMessage = "Registeration successfull";
            }
            catch (Exception ) 
             {
                ViewBag.Message = "Please fill the Form";
            }
            return View("Index", new Name());
             
            
        }
    }
}