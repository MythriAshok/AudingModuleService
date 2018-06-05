using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuditingModule.Controllers
{
    public class CompanyDetailsController : Controller
    {
        // GET: CompanyDetails
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CompanyDetailsView()
        {
            return View();
        }
    }
}