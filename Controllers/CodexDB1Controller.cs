using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodexWeb.Models;

namespace CodexWeb.Controllers
{
    public class CodexDB1Controller : Controller
    {
        // GET: CodexDB1
        public ActionResult Index()
        {
            var entities = new CodexDBappEntities();
            return View(entities.CodexDB1.ToList());
           
        }

        // GET: CodexDB1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CodexDB1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodexDB1/Create
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

        // GET: CodexDB1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CodexDB1/Edit/5
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

        // GET: CodexDB1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CodexDB1/Delete/5
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
