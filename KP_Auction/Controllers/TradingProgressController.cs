﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KP_Auction.Controllers
{
    public class TradingProgressController : Controller
    {
        // GET: TreadingProgress
        public ActionResult Index()
        {
            return View();
        }

        // GET: TreadingProgress/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TreadingProgress/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TreadingProgress/Create
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

        // GET: TreadingProgress/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TreadingProgress/Edit/5
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

        // GET: TreadingProgress/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TreadingProgress/Delete/5
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