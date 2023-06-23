using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;
namespace Task2.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Insert()
        {
            List<Image> images = ListOfImages.imgSrcs;
            ViewBag.images = images;
            return View();
        }


        public ActionResult display(int id ,string name,string img)
        {
            Image_Data img_data = new Image_Data();
            img_data.Id = id;
            img_data.Name = name;
            img_data.src = new Image() { SrcOfImage = img };
            ViewBag.img_data = img_data;
            return View();
        }
    }
}