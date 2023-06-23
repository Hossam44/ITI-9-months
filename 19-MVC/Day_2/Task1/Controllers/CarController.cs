using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
namespace Task1.Controllers
{
    public class CarController : Controller
    {
        // GET: car
        public ActionResult getall()
        {
            List<car> carList = ListCars.Allcars;
            ViewBag.Cars = carList;
            return View();
        }
        public ActionResult getByID(int id)
        {
            car selected_Car = ListCars.Allcars.FirstOrDefault(c=>c.ID==id);
            ViewBag.selected_Car = selected_Car;
            return View();
        }
        public ActionResult EditByID(int id)
        {
            car Edit_Car = ListCars.Allcars.FirstOrDefault(c => c.ID == id);
            ViewBag.Edit_Car = Edit_Car;
            return View();
        }
        [HttpPost]
        public ActionResult EditByID(int id,string Model,string Color, string Manfacture)
        {
            car Edit_Car = ListCars.Allcars.FirstOrDefault(c => c.ID == id);
            Edit_Car.Model = Model;
            Edit_Car.Color = Color;
            Edit_Car.Manfacture = Manfacture;

            return RedirectToAction("getall");
        }

        public ActionResult insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insert(int id, string Model, string Color, string Manfacture)
        {
            car newCar = new car() { ID=id,Model=Model,Color=Color,Manfacture=Manfacture};
            ListCars.Allcars.Add(newCar);
            return RedirectToAction("getall");
        }

        public ActionResult delete(int id)
        {
            car deletedCar = ListCars.Allcars.FirstOrDefault(c=>c.ID==id);
            ListCars.Allcars.Remove(deletedCar);

            return RedirectToAction("getall");
        }
    }
}