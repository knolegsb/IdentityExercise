using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdnetityExercise.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            var model = new List<Models.TestViewModel>();
            model.Add(new Models.TestViewModel() { Title = Models.Title.Miss });
            model.Add(new Models.TestViewModel() { Title = Models.Title.Mrs });
            model.Add(new Models.TestViewModel() { Title = null });

            return View(model);
        }
    }
}