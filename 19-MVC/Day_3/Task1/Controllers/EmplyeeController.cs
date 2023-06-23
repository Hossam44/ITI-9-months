using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class EmplyeeController : Controller
    {
        NorthwindEntities context = new NorthwindEntities();
        // GET: Emplyee
        public ActionResult Index()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(context.Products.ToList());
        }

        [HttpPost]
        public ActionResult Index(int CategoryID)
        {
            ViewBag.Categories = context.Categories.ToList();
            Category category = context.Categories.Find(CategoryID);

            return View(category.Products);
        }

        // GET: Emplyee/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Products.Find(id));
        }

        // GET: Emplyee/Create
        public ActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(new Product()
            {
                ProductID = 100,
                ProductName = "",
                SupplierID = 1,
                CategoryID = 1,
                QuantityPerUnit = "",
                UnitPrice = 1,
                UnitsInStock = 1,
                UnitsOnOrder = 1,
                ReorderLevel = 1,
                Discontinued = true
            });
        }

        // POST: Emplyee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.Categories = context.Categories.ToList();
            try
            {
                // TODO: Add insert logic here
                Product product = new Product()
                {
                    ProductName = collection[1],
                    SupplierID = int.Parse(collection[2]),
                    CategoryID = int.Parse(collection[3]),
                    QuantityPerUnit = collection[4],
                    UnitPrice = decimal.Parse(collection[5]),
                    UnitsInStock = short.Parse(collection[6]),
                    UnitsOnOrder = short.Parse(collection[7]),
                    ReorderLevel = short.Parse(collection[8]),
                    Discontinued = bool.Parse("true")
                };
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emplyee/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(context.Products.Find(id));
        }

        // POST: Emplyee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Product product = context.Products.Find(id);

                product.ProductName = collection[2];
                product.SupplierID = int.Parse(collection[3]);
                product.CategoryID = int.Parse(collection[4]);
                product.QuantityPerUnit = collection[5];
                product.UnitPrice = decimal.Parse(collection[6]);
                product.UnitsInStock = short.Parse(collection[7]);
                product.UnitsOnOrder = short.Parse(collection[8]);
                product.ReorderLevel = short.Parse(collection[9]);
                product.Discontinued = bool.Parse("true");
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Emplyee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Products.Find(id));
        }

        // POST: Emplyee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Product product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
