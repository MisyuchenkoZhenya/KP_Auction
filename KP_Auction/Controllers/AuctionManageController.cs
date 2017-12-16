﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KP_Auction.Models;
using KP_Auction.Repositories;


namespace KP_Auction.Controllers
{
    public class AuctionManageController : Controller
    {
        // GET: AuctionManage
        public ActionResult Index()
        {
            return RedirectToAction("GetAuctions");
        }

        public ActionResult GetAuctions()
        {
            AuctionRepository repository = new AuctionRepository();
            ModelState.Clear();
            return View(repository.GetAll("GetFutureAuctions"));
        }

        public ActionResult AddDeals(int id)
        {
            DealRepository repository = new DealRepository();
            ModelState.Clear();
            ViewBag.AuctionId = id;
            return View(repository.GetForAuction(id));
        }

        // GET: AuctionManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deal/Create
        public ActionResult NewDeal(int id)
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

            ViewBag.Id = id;
            return View(model);
        }

        // POST: Deal/Create
        [HttpPost]
        public ActionResult NewDeal(DealModel ModelObject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DealRepository repository = new DealRepository();
                    repository.Add(ModelObject);
                    return RedirectToAction("AddDeals", "AuctionManage", new { id = ModelObject.Auction_Id });
                }

                return View();
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
