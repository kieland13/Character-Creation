using DAndDWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DAndDWebsite.Controllers
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

        public IActionResult Dice()
        {
            Dice diceObject = new Dice();

            diceObject.d20Dice = 15;
            diceObject.d10Dice = 9;
            diceObject.d8Dice = 6;
            diceObject.d6Dice = 4;
            diceObject.d4Dice = 2;
            return View(diceObject);
        }

        public ActionResult RollD20Dice(int d20Dice)
        {
            Random randomDice = new Random();
            Dice d20Object = new Dice();

            d20Dice = randomDice.Next(1, 21);

            d20Object.d20Dice = d20Dice;


            return View(d20Object);
        }

        public ActionResult RollD10Dice(int d10Dice)
        {
            Random random10Dice = new Random();
            Dice d10Object = new Dice();

            d10Dice = random10Dice.Next(1, 11);

            d10Object.d10Dice = d10Dice;


            return View(d10Object);
        }

        public ActionResult RollD8Dice(int d8Dice)
        {
            Random random8Dice = new Random();
            Dice d8Object = new Dice();

            d8Dice = random8Dice.Next(1, 9);

            d8Object.d8Dice = d8Dice;


            return View(d8Object);
        }

        public ActionResult RollD6Dice(int d6Dice)
        {
            Random random6Dice = new Random();
            Dice d6Object = new Dice();

            d6Dice = random6Dice.Next(1, 7);

            d6Object.d6Dice = d6Dice;


            return View(d6Object);
        }

        public ActionResult RollD4Dice(int d4Dice)
        {
            Random random4Dice = new Random();
            Dice d4Object = new Dice();

            d4Dice = random4Dice.Next(1, 5);

            d4Object.d4Dice = d4Dice;


            return View(d4Object);
        }
    }
}
