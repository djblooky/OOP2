﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint2;

namespace BasicMVCSite.Controllers
{
    public class InstrumentController : Controller
    {
        Instrument Instrument;

        public InstrumentController()
        {
            Instrument = new Guitar();
        }

        // GET: Instrument
        public ActionResult Index()
        {
            return View(Instrument);
        }

        // GET: Instrument/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Instrument/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instrument/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Instrument/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Instrument/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Instrument/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Instrument/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}