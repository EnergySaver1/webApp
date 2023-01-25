using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // create controler for order
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
            OrderDataMapper orderDataMapper = new OrderDataMapper();
            var orders = orderDataMapper.GetAllOrders();
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            OrderDataMapper orderDataMapper = new OrderDataMapper();
            var order = orderDataMapper.GetOrderById(id);
            return View(order);
        }

        // GET: OrderController/Create
        public void Create(Order order)
        {
            OrderDataMapper orderDataMapper = new OrderDataMapper();
            orderDataMapper.InsertOrder(order);
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
