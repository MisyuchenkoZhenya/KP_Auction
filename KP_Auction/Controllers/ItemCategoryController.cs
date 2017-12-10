﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Models;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class ItemCategoryController : Controller
    {
        // GET: ItemCategory
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            ItemCategoryRepository repository = new ItemCategoryRepository();
            ModelState.Clear();
            return View(repository.GetAll());
        }

        // GET: ItemCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ItemCategory/Create
        public ActionResult Create()
        {
            return View(new ItemCategoryModel());
        }

        // POST: ItemCategory/Create
        [HttpPost]
        public ActionResult Create(ItemCategoryModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ItemCategoryRepository repository = new ItemCategoryRepository();
                    repository.Add(ModelObject);
                    return RedirectToAction("GetAll");
                }

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
            ItemCategoryRepository repository = new ItemCategoryRepository();

            return View(repository.GetById(id));
        }

        // POST: ItemCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ItemCategoryModel ModelObject)
        {
            try
            {
                ItemCategoryRepository repository = new ItemCategoryRepository();
                repository.Update(ModelObject);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemCategory/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ItemCategoryRepository repository = new ItemCategoryRepository();
                repository.Delete(id);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
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
