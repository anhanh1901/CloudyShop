using CloudyShop.Models;
using System.Linq;
using System.Web.Mvc;

namespace CloudyShop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.OederCount = db.Orders.Count();
            ViewBag.AccountCount = db.Users.Count();
            ViewBag.ProductCount = db.Products.Count();
            ViewBag.NewCount = db.News.Count();
            return View();
        }
    }
}