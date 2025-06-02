using Microsoft.AspNetCore.Mvc;
using product_task1.Data;

namespace product_task1.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContextcs context = new ApplicationDbContextcs();
        public ViewResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
        public ViewResult Details()
        {
            var products = context.Products.ToList();
            return View(products);
        }
        public ViewResult Create()
        {
            return View();
        }
    }
}
