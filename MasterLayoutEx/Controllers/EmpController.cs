using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<EMPDATA> L = ODOps.GetAll();
            return View(L);
        }
        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Edit(int? id)
        {

           
                return View(ODOps.GetEmp((int)id));

            }


        
        

    }
}