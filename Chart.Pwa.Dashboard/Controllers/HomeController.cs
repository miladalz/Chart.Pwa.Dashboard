using Chart.Pwa.Dashboard.Common;
using Chart.Pwa.Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chart.Pwa.Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult GetBarChart()
        {
            Random random = new Random();
            var data = new List<decimal>();
            var labels = new List<string>();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 10; i++)
            {
                data.Add(random.Next(1, 500));
                labels.Add(chars[random.Next(chars.Length)].ToString());
            }

            var chartDataModel = new ChartDataModel()
            {
                Labels = labels,
                DataSets = new List<DataSet>()
                {
                    new DataSet()
                    {
                        Label = "My First Dataset",
                        Data = data,
                        BackgroundColor = Constants.BackgroundColor,
                        BorderColor = Constants.BorderColor,
                        BorderWidth = 1
                    },
                    new DataSet()
                    {
                        Label = "My Second Dataset",
                        Data = data,
                        BackgroundColor = Constants.BackgroundColor,
                        BorderColor = Constants.BorderColor,
                        BorderWidth = 1
                    }
                }
            };

            return Json(chartDataModel);
        }
    }
}