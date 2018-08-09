using System.Linq;
using System.Web.Mvc;
using Chick.Models;
using Chick.Models.Widoki;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chick.Controllers
{
    [TestClass]
    public class TestControllerTest : Controller
    {
        // GET: TestControllerTest
        [TestMethod]
        public void Index()
        {
            ChickDbContext db = new ChickDbContext();
            Widoki w = new Widoki();
            var q = db.Diety.ToList();
            var z = w.Jadlospisy.ToList();
            var x = w.DaniaWPosilku.ToList();
        }
    }
}