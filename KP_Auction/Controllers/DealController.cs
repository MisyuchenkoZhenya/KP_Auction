﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Models;
using KP_Auction.Repositories;

namespace KP_Auction.Controllers
{
    public class DealController : Controller
    {
        // GET: Deal
        public ActionResult Index()
        {
            return RedirectToAction("GetAll");
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
            AuctionRepository auctionRep = new AuctionRepository();
            ParticipantRepository participantRep = new ParticipantRepository();
            DealStateRepository dealStateRep = new DealStateRepository();
            ItemRepository itemRep = new ItemRepository();
        
            DealModel model = new DealModel
            {
                Auctions = auctionRep.GetAll(),
                Buyers = participantRep.GetAll(),
                Sellers = participantRep.GetAll(),
                DealStates = dealStateRep.GetAll(),
                Items = itemRep.GetAll()
            };

            return View(model);
        }

        // POST: Deal/Create
        [HttpPost]
        public ActionResult Create(DealModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DealRepository repository = new DealRepository();
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

        // GET: Deal/Edit/5
        public ActionResult Edit(int id)
        {
            DealRepository repository = new DealRepository();
            AuctionRepository auctionRep = new AuctionRepository();
            ParticipantRepository participantRep = new ParticipantRepository();
            DealStateRepository dealStateRep = new DealStateRepository();
            ItemRepository itemRep = new ItemRepository();

            DealModel model = repository.GetById(id);
            model.Auctions = auctionRep.GetAll();
            model.Buyers = participantRep.GetAll();
            model.Sellers = participantRep.GetAll();
            model.DealStates = dealStateRep.GetAll();
            model.Items = itemRep.GetAll();

            return View(model);
        }

        // POST: Deal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DealModel ModelObject)
        {
            try
            {
                DealRepository repository = new DealRepository();
                repository.Update(ModelObject);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deal/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                DealRepository repository = new DealRepository();
                repository.Delete(id);

                return RedirectToAction("GetAll");
            }
            catch
            {
                return View();
            }
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
