using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCF_Web.Models;
using PagedList;

namespace QLCF_Web.Controllers
{
    public class ProductController : Controller
    {
        
        // GET: Product
        QUANLYCAPHE1Entities3 db= new QUANLYCAPHE1Entities3();
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult ShowProduct(int? page, int? pagesize)
        {
            if (page == null)
            {
                page = 1;
            }
            if (pagesize == null)
            {
                pagesize = 8;
            }
            var listsp = db.THUC_UONG.ToList();
            return View(listsp.ToPagedList((int)page, (int)pagesize));

        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var sp = db.THUC_UONG.Where(x => x.MA_THUC_UONG == id).FirstOrDefault();
            return View(sp);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
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

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
