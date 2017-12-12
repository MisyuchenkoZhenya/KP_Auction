using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Models;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class DealStateController : Controller
    {
        // GET: DealState
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            DealStateRepository repository = new DealStateRepository();
            ModelState.Clear();
            return View(repository.GetAll());
        }

        // GET: DealState/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DealState/Create
        public ActionResult Create()
        {
            return View(new DealStateModel());
        }

        // POST: DealState/Create
        [HttpPost]
        public ActionResult Create(DealStateModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DealStateRepository repository = new DealStateRepository();
                    repository.Add(ModelObject);
                    return RedirectToAction("GetAll");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: DealState/Edit/5
        public ActionResult Edit(int id)
        {
            DealStateRepository repository = new DealStateRepository();

            return View(repository.GetById(id));
        }

        // POST: DealState/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DealStateModel ModelObject)
        {
            try
            {
                DealStateRepository repository = new DealStateRepository();
                repository.Update(ModelObject);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: DealState/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                DealStateRepository repository = new DealStateRepository();
                repository.Delete(id);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
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
