using Semana09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana09.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            if (Session["product"] == null)
                Session["product"] = new List<Product>();

            return View(Session["product"]);

        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var model = ((List<Product>)Session["product"]).Where(x => x.ProductId == id).FirstOrDefault();

            return View(model);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product model)
        {
            try
            {
                // TODO: Add insert logic here
                ((List<Product>)Session["product"]).Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = ((List<Product>)Session["product"]).Where(x => x.ProductId == id).FirstOrDefault();

            return View(model);
        }

        // POST: Product/Edit/5
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

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
