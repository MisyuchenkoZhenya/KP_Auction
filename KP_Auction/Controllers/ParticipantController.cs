using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Models;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class ParticipantController : Controller
    {
        // GET: Participant
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");
        }

        public ActionResult GetAll()
        {
            ParticipantRepository repository = new ParticipantRepository();
            ModelState.Clear();
            return View(repository.GetAll());
        }

        // GET: Participant/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Participant/Create
        public ActionResult Create()
        {
            return View(new ParticipantModel());
        }

        // POST: Participant/Create
        [HttpPost]
        public ActionResult Create(ParticipantModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ParticipantRepository repository = new ParticipantRepository();
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

        // GET: Participant/Edit/5
        public ActionResult Edit(int id)
        {
            ParticipantRepository repository = new ParticipantRepository();

            return View(repository.GetById(id));
        }

        // POST: Participant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ParticipantModel ModelObject)
        {
            try
            {
                ParticipantRepository repository = new ParticipantRepository();
                repository.Update(ModelObject);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: Participant/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ParticipantRepository repository = new ParticipantRepository();
                repository.Delete(id);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
        }

        // POST: Participant/Delete/5
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
