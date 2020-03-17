using MasterLayoutEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayoutEx.Controllers
{
    public class BindingExController : Controller
    {
        // GET: BindingEx
        [ActionName("Example")]
        public ActionResult Sample()
        {
            return View("Sample");
        }
        public ActionResult Index()
        {
            return View();
        
        }
        //Primitive type DataBinding
        public ActionResult Update(int id)
        {

            return View("Index",ODOps.GetEmp(id));
        }
        //Binding to Complex type
        //[HttpPost]
        //public ActionResult Update(EMPDATA E)
        //{
        //    return View();
        //}
        //Basic Type( Not Suggested)
        //[HttpPost]
        //public ActionResult Update(int EMPNO,string ENAME,string JOB,int MGR,DateTime HIREDATE,int SAL,int COMM,int DEPTNO)
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Update(FormCollection F)
        //{
        //    int eno = int.Parse(F["EMPNO"]);
        //    string en = F["ENAME"];
        //    return View();

        //}
        [HttpPost]
        public ActionResult Update([Bind(Exclude ="ENAME,JOB,DEPTNO")] EMPDATA E)
        {
            return View();
        }

    }
}