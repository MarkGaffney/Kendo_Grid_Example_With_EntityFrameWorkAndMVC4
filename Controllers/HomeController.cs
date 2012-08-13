using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;

using KendoUI.Models;

namespace KendoGridApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private MicropowerMembersEntities db = new MicropowerMembersEntities();
   

        public ActionResult Index()
        {
            var emps = new    List <Employee>();
            foreach (var ct in db.Contacts)
            {
              emps.Add( new Employee{ EmployeeName = ct.LastName, ID = ct.ID});
            }
            ViewBag.employees = emps;
                     
                      return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
                  return Json(db.Contacts.ToDataSourceResult(request));
        }

    }
}
