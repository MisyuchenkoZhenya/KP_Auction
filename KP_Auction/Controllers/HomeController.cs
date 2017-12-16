using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Configuration;
using KP_Auction.Models;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            if(Session["Role"] == null) Session["Role"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserRepository repository = new UserRepository();
                    IEnumerable<UserModel> users = repository.GetAll();
                    foreach(var obj in users)
                    {
                        if(ModelObject.Username == obj.Username &&
                           ModelObject.Password == obj.Password)
                        {
                            return Authorize(obj.Role);
                        }
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Authorize(string role)
        {
            Session["Role"] = role;
            if (role == "Admin")
            {
                return RedirectToAction("GetAll", "Auction");
            }
            else if(role == "User")
            {
                return RedirectToAction("GetAuctions", "AuctionManage");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Exit()
        {
            Session["Role"] = "";
            return RedirectToAction("Index");
        }
    }
}