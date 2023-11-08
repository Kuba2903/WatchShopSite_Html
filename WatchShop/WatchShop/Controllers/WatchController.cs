using Microsoft.AspNetCore.Mvc;
using WatchShop.Models;

namespace WatchShop.Controllers
{
    public class WatchController : Controller
    {
        private readonly IWatchService watchService;
        public WatchController(IWatchService watchService)
        {

            this.watchService = watchService;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Order")]
        public IActionResult OrderGet(WatchOrder order)
        {
            return View(order);
        }

        [HttpPost]
        public IActionResult Order(WatchOrder order)
        {
            if (ModelState.IsValid)
            {
                watchService.AddOrder(order);
                return RedirectToAction("Index");
            }else
                return View(order);
        }
    }
}
