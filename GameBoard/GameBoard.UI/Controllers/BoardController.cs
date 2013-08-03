using System.Web.Mvc;
using GameBoard.UI.Models;

namespace GameBoard.UI.Controllers
{
    public class BoardController : Controller
    {
        public ActionResult Index()
        {
            var board = new Board {Game = new Game {Name = "Eight by Eight"}, Width = 8, Height = 8};
            return View(board);
        }
    }
}
