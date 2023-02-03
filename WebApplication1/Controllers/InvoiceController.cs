using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Drawing;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InvoiceController : Controller
    {
        string filepath = @"C:\Users\ksedl\invoices.json";

        // GET: InvoiceController
        public ActionResult Index()
        {
            Gateway gateway = new Gateway();
            return View(gateway.DeserializeFromJson(filepath));
        }

        // GET: InvoiceController/Details
        public ActionResult Details(int id)
        {

            Gateway gateway = new Gateway();
            List<Invoice> invoices = gateway.DeserializeFromJson(filepath);
            Invoice item = invoices.FirstOrDefault(o => o.Id == id);
            return View(item);
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
            invoice.VariableSymbol = int.Parse(collection["VariableSymbol"]);

            Gateway gateway = new Gateway();
            List<Invoice> invoices = gateway.DeserializeFromJson(filepath);
            invoices.Add(invoice);
            gateway.SerializeToJson(invoices, filepath);
            return RedirectToAction("Index");

        }

        // GET: InvoiceController/Edit
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceController/Edit
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

        // GET: InvoiceController/Delete
        public ActionResult Delete(int id)
        {
            Gateway gateway = new Gateway();
            List<Invoice> invoices = gateway.DeserializeFromJson(filepath);
            var item = invoices.FirstOrDefault(o => o.Id == id);
            Console.WriteLine("***" + item.Id);
            return View(item);
        }

        // POST: InvoiceController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Invoice invoice, IFormCollection collection)
        {
            Gateway gateway = new Gateway();
            List<Invoice> invoices = gateway.DeserializeFromJson(filepath);
            
            foreach (Invoice i in invoices)
            {
                if (i.Id == invoice.Id)
                {
                    invoices.Remove(i);
                    break;
                }
            }
            gateway.SerializeToJson(invoices, filepath);
            return RedirectToAction("Index");

        }
    }
}
