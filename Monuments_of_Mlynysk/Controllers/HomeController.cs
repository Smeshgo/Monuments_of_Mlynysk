using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monuments_of_Mlynysk.Service;
using Microsoft.AspNetCore.Authorization;

namespace Monuments_of_Mlynysk.Controllers
{   [Controller]
    public class HomeController : Controller
    {
        //[Authorize]
        //public IActionResult Index()
        //{
        //    return Content(User.Identity.Name);
        //}
         //GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public string Hello(int id)
        {
            return $"id= {id}";
        }
        public ActionResult Autor()
        {
            return LocalRedirect("~/View/index.html");
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // GET: HomeController/Singelimg/
        public JsonResult Singlimg()
        {
            return Json(UploadImd.uploadImdSingle());
        }

        public JsonResult Dualimg()
        {
            return Json(UploadImd.uploadImdDual());
        }

        public JsonResult Eliteimg()
        {
            return Json(UploadImd.uploadImdElite());
        }

        public JsonResult Articles()
        {
            return Json(Article.articlesUpload());
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        

    }
}
