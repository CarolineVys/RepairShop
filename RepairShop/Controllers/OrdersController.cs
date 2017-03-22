using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepairShop.Models;

namespace RepairShop.Controllers
{
    public class OrdersController : Controller
    {
        private RepairShopContext dataBase = new RepairShopContext();
        public static int currentClientId;

        public ActionResult ShowAddingForm(int clientId)
        {
            currentClientId = clientId;
            return PartialView("AddOrder");
        }

        [HttpPost]
        public ActionResult AddOrder(Order order)
        {
            order.OrderDate = DateTime.Now.ToString("dd.MM.yyyy");
            order.ClientId = currentClientId;
            dataBase.Orders.Add(order);
            dataBase.SaveChanges();
            return RedirectToAction("Search", "Clients");
        }
    }
}