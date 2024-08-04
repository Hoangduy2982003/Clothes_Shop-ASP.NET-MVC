﻿using BanHangOnline.Models;
using BanHangOnline.Models.EF;
using System;
using System.Web.Mvc;

namespace BanHangOnline.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.Categories;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = BanHangOnline.Models.Common.Filter.FilterChar(model.Title);
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Categories.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.Alias = BanHangOnline.Models.Common.Filter.FilterChar(model.Title);
                db.Entry<Category>(model).Property(x => x.Title).IsModified = true;
                db.Entry<Category>(model).Property(x => x.Desctiption).IsModified = true;
                db.Entry<Category>(model).Property(x => x.Alias).IsModified = true;
                db.Entry<Category>(model).Property(x => x.SeoDescription).IsModified = true;
                db.Entry<Category>(model).Property(x => x.SeoKeyword).IsModified = true;
                db.Entry<Category>(model).Property(x => x.SeoTitle).IsModified = true;
                db.Entry<Category>(model).Property(x => x.Position).IsModified = true;
                db.Entry<Category>(model).Property(x => x.ModifiedDate).IsModified = true;
                db.Entry<Category>(model).Property(x => x.ModifiedBy).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var item = db.Categories.Find(id);
            if (item != null)
            {
                db.Categories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}