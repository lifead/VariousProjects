using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.DownloadFileAjaxjQuery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase fileInput)
        {
            if (fileInput != null)
            {
                // получаем имя файла
                string fileName = System.IO.Path.GetFileName(fileInput.FileName);
                // сохраняем файл в папку Files в проекте
                fileInput.SaveAs(Server.MapPath("~/App_Data/" + fileName));
            }
            return RedirectToAction("Index");
        }

    }
}