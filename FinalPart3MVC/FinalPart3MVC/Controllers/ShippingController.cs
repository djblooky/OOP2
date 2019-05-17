using ClassLibraryFinal;
using FinalPart3MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalPart3MVC.Controllers
{
    public class ShippingController : Controller
    {
        ShippingControllerViewModel viewModel;

        public ShippingController()
        {
            viewModel = new ShippingControllerViewModel();
        }

        // GET: Shipping
        public ActionResult Index()
        {
            return View(viewModel);
        }

        // GET: Shipping/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Shipping/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculateShipping(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                /*string s = "call calculate shipping here!";
                double cost = 7;
                viewModel.ShippingCost = cost;
                viewModel.ShippingMessage = s;*/

                DeliveryService service;
                uint numRefuels;
                uint shippingDistance;

                if (collection["ShippingMethods"].ToString() == "Snail Service")
                {
                    service = new SnailService((IShippingVehicle)(new Snail()));
                }
                else if (collection["ShippingMethods"].ToString() == "Uncle's Truck")
                {
                    service = new UnclesTruck((new Truck()));
                }
                else if (collection["ShippingMethods"].ToString() == "Air Express")
                {
                    service = new AirExpress((new Plane()));
                }

                //viewModel.ShippingZipCode = service.ShippingVehicle.ZipCode;
                viewModel.ShippingDistance = service.ShippingVehicle.MaxDistancePerRefuel;
                viewModel.CostRefills = service.CostPerRefuel;

                    return View(viewModel);
            }
            catch
            {
                return View();
            }
        }

        // POST: Shipping/Create
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

        // GET: Shipping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Shipping/Edit/5
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

        // GET: Shipping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Shipping/Delete/5
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
