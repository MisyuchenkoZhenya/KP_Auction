﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KP_Auction.Controllers
{
    public class ItemCategoryController : Controller
    {
        // GET: ItemCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: ItemCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemCategory/Create
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

        // GET: ItemCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemCategory/Edit/5
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

        // GET: ItemCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemCategory/Delete/5
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
