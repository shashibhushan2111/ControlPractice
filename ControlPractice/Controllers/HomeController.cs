using ControlPractice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ControlPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            //Creating object of CheckBoxList model class    
            CheckBoxList ChkItems = new CheckBoxList();
            //Additng items to the list    
            List<CheckBoxModel> ChkItem = new List<CheckBoxModel>()
        {
          new CheckBoxModel {Value=1,Text="ASP.NET",IsChecked=true },
          new CheckBoxModel {Value=1,Text="C#",IsChecked=false },
          new CheckBoxModel {Value=1,Text="MVC",IsChecked=false },
          new CheckBoxModel {Value=1,Text="Web API" ,IsChecked=false},
          new CheckBoxModel {Value=1,Text="SignalR",IsChecked=false },
          new CheckBoxModel {Value=1,Text="SQL" ,IsChecked=false},
        };
            //assigning records to the CheckBoxItems list     
            ChkItems.CheckBoxItems = ChkItem;
            return View(ChkItems);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}