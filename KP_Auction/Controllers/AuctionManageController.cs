using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KP_Auction.Controllers
{
    public class AuctionManageController : Controller
    {
        // GET: AuctionManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuctionManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuctionManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionManage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuctionManage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuctionManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuctionManage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
