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
    public class TraineesController : Controller
    {
        public ITraineeRepository TraineeRepository { get; set; }
        public TraineesController(ITraineeRepository traineeRepository)
        {
            TraineeRepository = traineeRepository;
        }
        public ActionResult Index()
        {
            return View(TraineeRepository.GetAll());
        }
        public ActionResult Details(int id)
        {
            return View(TraineeRepository.GetDetails(id));
        }
      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Trainee tr)
        {
            TraineeRepository.Insert(tr);
           return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            try
            {
                TraineeRepository.DeleteTr(id);

                return View(TraineeRepository.GetAll());
            }
            catch
            {
                return View("Empty");
            }
        }
        public ActionResult Edit(int id)
        {
            return View(TraineeRepository.GetDetails(id)); 
        }
        [HttpPost]
        public ActionResult Edit(int id, Trainee tr)
        {
            TraineeRepository.UpdateTr(id,tr);
            return View(Index);
        }
        
    }
}
