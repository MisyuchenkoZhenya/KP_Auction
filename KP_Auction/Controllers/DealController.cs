using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class DealController : Controller
    {
        // GET: Deal
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");//View();
        }

        public ActionResult GetAll()
        {
            DealRepository repository = new DealRepository();
            ModelState.Clear();
            return View(repository.GetAll());
        }

        // GET: Deal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deal/Create
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

        // GET: Deal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deal/Edit/5
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

        // GET: Deal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deal/Delete/5
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
