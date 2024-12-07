using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BlogApp.DataAccess;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(Post post)
        {
            try
            {
                await PostDataAccess.Create(post);
                Response.StatusCode = 200;

                return Json(new { message = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Edit(Post post)
        {
            try
            {
                await PostDataAccess.Update(post);
                Response.StatusCode = 200;

                return Json(new { message = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetPosts()
        {
            try
            {
                var posts = await PostDataAccess.GetPosts();
                Response.StatusCode = 200;

                return Json(new { items = posts, message = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int Id)
        {
            try
            {
                await PostDataAccess.Delete(Id);
                Response.StatusCode = 200;

                return Json(new { message = "ok" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message });
            }
        }
    }
}