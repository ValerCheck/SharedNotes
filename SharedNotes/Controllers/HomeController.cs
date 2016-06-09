using System;
using System.Web.Mvc;
using SharedNotes.Domain.Entities;
using SharedNotes.Domain.Abstract;

namespace SharedNotes.Controllers
{
    public class HomeController : Controller
    {
        private IWorkSpaceRepository _workSpaceRepository;

        public HomeController(IWorkSpaceRepository wsRepository)
        {
            _workSpaceRepository = wsRepository;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(WorkSpace workSpace)
        {
            if (!ModelState.IsValid) return View();

            Session["SessionName"] = workSpace.Name;
            workSpace.Hash = workSpace.Name.GetMd5Hash();
            workSpace.Id = Guid.NewGuid();
            _workSpaceRepository.AddWorkSpace(workSpace);

            return View("Dashboard", workSpace);
        }

        public ViewResult About()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
    }
}