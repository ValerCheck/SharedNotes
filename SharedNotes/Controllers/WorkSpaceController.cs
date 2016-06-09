using System.Web.Mvc;
using SharedNotes.Domain.Entities;
using SharedNotes.Domain.Abstract;

namespace SharedNotes.Controllers
{
    public class WorkSpaceController : Controller
    {
        private IWorkSpaceRepository _repository;
        private WorkSpace _selectedWorkSpace;

        [HttpGet]
        public ActionResult AllNotes(WorkSpace workspace)
        {
            _selectedWorkSpace = workspace;
            return View();
        }
    }
}