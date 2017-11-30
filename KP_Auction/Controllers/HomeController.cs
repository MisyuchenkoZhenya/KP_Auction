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
        static string connectionString = WebConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString;
        SqlConnection db = new SqlConnection(connectionString);

        public ActionResult Index()
        {
            return Content(connectionString);//View();
        }
        
    }
}