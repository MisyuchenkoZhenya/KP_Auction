using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KP_Auction.Controllers
{
    public class DealStateController : Controller
    {
        // GET: DealState
        public ActionResult Index()
        {
            return View();
        }

        // GET: DealState/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DealState/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DealState/Create
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

        // GET: DealState/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DealState/Edit/5
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

        // GET: DealState/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DealState/Delete/5
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
