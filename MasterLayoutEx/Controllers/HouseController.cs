using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class HouseController : Controller
    {
        private readonly DemoEntities D = new DemoEntities();

        // GET: House
        public ActionResult Index()
        {
            var employee = D.EMPDATAs.ToList();
            return View(employee);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        
        public ActionResult Create([Bind(Include = "ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO")]EMPDATA employee)
        {
            if (ModelState.IsValid)
            {
                D.EMPDATAs.Add(employee);
                D.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}