using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArticlesAppSQL.Models;

namespace ArticlesAppSQL.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            using (Article db = new Article())
            {
                return View(db.tblArticles.ToList());
            }

        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            using (Article db = new Article())
            {
                return View(db.tblArticles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(tblArticles article)
        {
            try
            {
                using (Article db = new Article())
                {

                    db.tblArticles.Add(article);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            using (Article db = new Article())
            {
                return View(db.tblArticles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tblArticles article)
        {
            try
            {
                using (Article db = new Article())
                {
                    db.Entry(article).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            using (Article db = new Article())
            {
                return View(db.tblArticles.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, tblArticles article)
        {
            try
            {
                // TODO: Add delete logic here
                using (Article db = new Article())
                {
                    article = db.tblArticles.Where(x => x.Id == id).FirstOrDefault();
                    db.tblArticles.Remove(article);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
