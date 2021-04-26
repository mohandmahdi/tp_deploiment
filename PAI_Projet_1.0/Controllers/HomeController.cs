using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PAI_Projet_1._0.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using PAI_Projet_1._0.dal;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace PAI_Projet_1._0.Controllers
{

    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        //private readonly MockEvent _event = new MockEvent();

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
       
        public IActionResult Index()
        {
 
            return View("Views/login.cshtml");
        }
        public IActionResult Home()
        {
            return View("Views/home.cshtml");
        }
        [HttpPost]
        public IActionResult Hand(int data)
        {
            MockEvent _event = new MockEvent(configuration);
            List<Event> liste = _event.GetEvents(data);
            Dictionary<List<Event>, int> dic = new Dictionary<List<Event>, int>();
            dic.Add(liste, data);
            //return View("Views/MainCourante.cshtml", _event.GetEvents(data));
            return View("Views/MainCourante.cshtml", dic);
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

        [HttpPost]
        public void Add(String titre,int data)
        {
            MockEvent _event = new MockEvent(configuration);
            _event.AddEvent(titre,data);
        }

        [HttpPost]
        public IActionResult AddNew(String titre,String desc, [FromForm(Name = "file")] IFormFile file, int data )
        {
            MockEvent _event = new MockEvent(configuration);
            string image = "";
            if (file != null)

                if (file.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(file.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);
                    image = newFileName;
                    // Combines two strings into a path.
                    var filepath =new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";
                    
                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                }
            _event.AddNewEvent(titre, desc, image,data);
            //return RedirectToAction("Hand","Home", new {data=data });
 
            List<Event> liste = _event.GetEvents(data);
            Dictionary<List<Event>, int> dic = new Dictionary<List<Event>, int>();
            dic.Add(liste, data);
            //return View("Views/MainCourante.cshtml", _event.GetEvents(data));
            return View("Views/MainCourante.cshtml", dic);


        }


        [HttpPost]
        public IActionResult Detail(String title, String desc,String image, String date)
        {

            Event e = new Event(date, desc, title,image,1);
            return View("Views/EventDetails.cshtml", e);
        }


        [HttpPost]
        public IActionResult Connect(String email , String password)
        {
            if (email == "team4@team.com" && password== "aaa")
            {
                return View("Views/home.cshtml");
            }
            else
            {
                return View("Views/login.cshtml");

            }
        }

        public IActionResult Sites()
        {
            MockSites _site = new MockSites(configuration);
            List<Sites> liste = _site.GetSites();
            return View("Views/Sites.cshtml", liste);
        }

        public IActionResult Profile()
        {
            
            return View("Views/Profile.cshtml");
        }
    }
}
