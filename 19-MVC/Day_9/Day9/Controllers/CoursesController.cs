using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Data;
using TrainingCenter.Models;
using TrainingCenter.Repositories;

namespace TrainingCenter.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {

        public ICourseRepoistory CourseRepository { get; set; }
        public CoursesController(ICourseRepoistory courseRepository)
        {
            CourseRepository = courseRepository;
        }
        public ActionResult Index()
        {
            return View(CourseRepository.GetAll());
        }
        public ActionResult Details(int id)
        {
            return View(CourseRepository.GetDetails(id));
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Course tr)
        {
            CourseRepository.Insert(tr);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            try
            {
                CourseRepository.DeleteCourse(id);

                return View(CourseRepository.GetAll());
            }
            catch
            {
                return View("Empty");
            }
        }
        public ActionResult Edit(int id)
        {
            return View(CourseRepository.GetDetails(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Course cs)
        {
            CourseRepository.UpdateCourse(id, cs);
            return View(cs);
        }

    }
}
