using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class OrderController : Controller
    {
        
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
        [HttpGet]
        public ActionResult Create(Order order)
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection formcollection)
        {
            Order order = new Order();
            OrderDataMapper orderDataMapper = new OrderDataMapper();
            
            order.Start_date = DateTime.Parse(formcollection["Start_date"]);
            order.End_date = DateTime.Parse(formcollection["End_date"]);
            order.State = formcollection["State"];
            order.Description = formcollection["Description"];
            order.Customer_id = int.Parse(formcollection["Customer_id"]);
            order.Price = int.Parse(formcollection["Price"]);
            order.Repair_type_id = int.Parse(formcollection["Repair_type_id"]);
            
            Console.WriteLine(order.ToString());
            
            orderDataMapper.InsertOrder(order);
            return RedirectToAction("Index");
            
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
