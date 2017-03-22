using System.Linq;
using System.Web.Mvc;
using RepairShop.Models;

namespace RepairShop.Controllers
{
    public class ClientsController : Controller
    {
        private RepairShopContext dataBase = new RepairShopContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            dataBase.Clients.Add(client);
            dataBase.SaveChanges();
            return RedirectToAction("Index", "Clients");
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult SearchClient(string name)
        {
            var resultData = dataBase.Clients.Where(a => a.Surname.Contains(name) || a.Name.Contains(name)).ToList();
            return PartialView(resultData);
        }

        public ActionResult Details(int id)
        {
            var detailsModel = dataBase.Clients.FirstOrDefault(a => a.Id == id);
            var orders = dataBase.Orders.Where(m => m.ClientId == id);
            ViewBag.Orders = orders;
            return View(detailsModel);
        }


    }
}