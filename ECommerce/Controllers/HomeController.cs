using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        EcommerceContext db = new EcommerceContext();
        public async  Task<IActionResult> Index()
        {
            
            using (var context = new EcommerceContext()) // YourDbContext, projenizdeki DbContext türevidir
            {
                var model =await context.Products.Include(x => x.Images).ToListAsync();
                    
                return View(model);
            }
            
        }
        
        [HttpGet] 
        public IActionResult ProductDetails(int id)
        { 
            Product product= db.Products.Where(x=>x.Id==id).Include(x=>x.Images).FirstOrDefault();
            
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}