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
    public class TracksController : Controller
    {
        public ITrackRepoistory TrackRepository { get; set; }
        public TracksController(ITrackRepoistory trackRepository)
        {
            TrackRepository = trackRepository;
        }
        public ActionResult Index()
        {
            return View(TrackRepository.GetAll());
        }
        public ActionResult Details(int id)
        {
            return View(TrackRepository.GetDetails(id));
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Track tr)
        {
            TrackRepository.Insert(tr);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            try
            {
                TrackRepository.DeleteTrack(id);

                return View(TrackRepository.GetAll());
            }
            catch
            {
                return View("Empty");
            }
        }
        public ActionResult Edit(int id)
        {
            return View(TrackRepository.GetDetails(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Track tr)
        {
            TrackRepository.UpdateTrack(id, tr);
            return View(tr);
        }

    }
}
