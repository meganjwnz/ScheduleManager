using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ScheduleManager.Model;

namespace ScheduleManager.Controllers
{
    public class MainController : Controller
    {
        private DAL.ShiftDAL dal;
        public MainController()
        {
            dal = new DAL.ShiftDAL();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Main/Test")]
        public IActionResult Test()
        {
            List<Shift> shifts = dal.GetShifts();
            return Json(shifts);
        }
    }
}