using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Drawing;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InvoiceController : Controller
    {
        string filepath = @"C:\Users\ksedl\test1.source2.bin";
        List<Invoice> invoices = new List<Invoice>();
        
        // GET: InvoiceController
        public ActionResult Index()
        {
            return View(invoices);
        }

        // GET: InvoiceController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: InvoiceController/Create
        public ActionResult Create(int id)
        {
            OrderDataMapper orderDataMapper = new OrderDataMapper();
            Order order = orderDataMapper.GetOrderById(id);
            Invoice invoice = new Invoice(order);
            return View(invoice);
        }

        // POST: InvoiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            Invoice invoice = new Invoice();

            invoice.Ico = int.Parse(collection["Ico"]);
            invoice.Dic = int.Parse(collection["Dic"]);
            invoice.BankAccount = int.Parse(collection["BankAccount"]);
            invoice.BankCode = int.Parse(collection["BankCode"]);
            invoice.Id = int.Parse(collection["Id"]);
            invoice.Start_date = DateTime.Parse(collection["Start_date"]);
            invoice.End_date = DateTime.Parse(collection["End_date"]);
            invoice.State = collection["State"];
            invoice.Description = collection["Description"];
            invoice.Customer_id = int.Parse(collection["Customer_id"]);
            invoice.Repair_type_id = int.Parse(collection["Repair_type_id"]);
            invoice.Price = Decimal.Parse(collection["Price"]);

            Console.WriteLine("***" + invoice.ToString());
            invoices.Add(invoice);
            return RedirectToAction("Index");

        }

        // GET: InvoiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceController/Edit/5
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

        // GET: InvoiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceController/Delete/5
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
