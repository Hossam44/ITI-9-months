﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4.Areas.Finance.Controllers
{
    [HandleError(View = "Error")]
    public class FinanceController : Controller
    {
        // GET: Finance/Finance
        public ActionResult Index()
        {
            int b = 0;
            int a = int.Parse("1") / b;
            return View();
        }

        // GET: Finance/Finance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Finance/Finance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finance/Finance/Create
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

        // GET: Finance/Finance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Finance/Finance/Edit/5
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

        // GET: Finance/Finance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Finance/Finance/Delete/5
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
