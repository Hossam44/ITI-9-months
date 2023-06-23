using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2.Models;

namespace Task_2.Controllers
{
    public class FormController : Controller
    {

        public ActionResult Insert()
        {
            List<Image> images = ListOfImages.imgSrcs;
            ViewBag.images = images;
            return View();
        }
        public ActionResult show(int id,string name,string src)
        {
            Image_Data img_data = new Image_Data();
            img_data.Id = id;
            img_data.Name = name;
            img_data.src = new Image() { SrcOfImage= src };
            ViewBag.img_data = img_data;
            return RedirectToAction("show");
        }
        public ActionResult display()
        {
            int id = 0; string name="sss"; string src = "jjj";
            Image_Data img_data = new Image_Data();
            img_data.Id = id;
            img_data.Name = name;
            img_data.src = new Image() { SrcOfImage = src };
            ViewBag.mg_data = img_data;
            return RedirectToAction("show");
        }
    }
}