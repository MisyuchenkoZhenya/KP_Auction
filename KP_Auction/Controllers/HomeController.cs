using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace KP_Auction.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("GetAll", "Auction");
        }
        
    }
}