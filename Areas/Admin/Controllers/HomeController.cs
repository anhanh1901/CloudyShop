using CloudyShop.Models;
using System.Collections.Generic;
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
          
            ViewBag.OrderCount = db.Orders.Count();
            ViewBag.AccountCount = db.Users.Count();
            ViewBag.ProductCount = db.Products.Count();
            ViewBag.NewCount = db.News.Count();
            return View();    
        }
        public ActionResult Refresh()
        {
            var item = new ThongKeModel();

            ViewBag.Visitors_online = HttpContext.Application["visitors_online"];
            var hn = HttpContext.Application["HomNay"];
            item.HomNay = HttpContext.Application["HomNay"].ToString();
            item.HomQua = HttpContext.Application["HomQua"].ToString();
            item.TuanNay = HttpContext.Application["TuanNay"].ToString();
            item.TuanTruoc = HttpContext.Application["TuanTruoc"].ToString();
            item.ThangNay = HttpContext.Application["ThangNay"].ToString();
            item.ThangTruoc = HttpContext.Application["ThangTruoc"].ToString();
            item.TatCa = HttpContext.Application["TatCa"].ToString();
            return PartialView(item);
        }
        public ActionResult BestSellingProduct()
        {
            var bestSellingProducts =db.OrderDetails
                        .GroupBy(od => od.ProductId)
                        .Select(g => new { ProductId = g.Key, TotalQuantity = g.Sum(od => od.Quantity) })
                        .OrderByDescending(x => x.TotalQuantity)
                        .Take(5) // Lấy ra top 5 sản phẩm bán chạy nhất
                        .ToList();

            List<BestSellingProduct> productsInfo = new List<BestSellingProduct>();

            foreach (var product in bestSellingProducts)
            {
                // Lấy thông tin chi tiết của từng sản phẩm
                var productDetail = db.Products.FirstOrDefault(p => p.Id == product.ProductId);
                if (productDetail != null)
                {
                    productsInfo.Add(new BestSellingProduct
                    {
                        Product = productDetail,
                        TotalQuantitySold = product.TotalQuantity
                    });
                }
            }

            return PartialView(productsInfo); // Trả về view hiển thị thông tin của top 5 sản phẩm bán chạy nhất kèm số lượng bán
        }
    }   
    
}