﻿using Microsoft.AspNetCore.Mvc;
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
            return View(watchService.GetOrders());
        }

        [HttpGet]
        [ActionName("Order")]
        public IActionResult OrderGet()
        {
            return View();
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var obj = watchService.FindOrder(id);

            if (obj != null)
            {
                return View(obj);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Edit(WatchOrder order)
        {
            if (ModelState.IsValid)
            {
                watchService.UpdateOrder(order);
                return RedirectToAction("Index");
            }
            else
                return View(order);
        }

        [HttpGet]
        public IActionResult Delete(WatchOrder watch)
        {
            return View(watch);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var obj = watchService.FindOrder(id);

            if(obj != null)
            {
                watchService.DeleteOrder(id);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var obj = watchService.FindOrder(id);

            if (obj != null)
            {
                return View(obj);
            }
            else
            {
                return NotFound();
            }
        }

        
    }
}
