using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController1
        public ActionResult Index()
        {
            ClientDataMapper clientDataMapper = new ClientDataMapper();
            var clients = clientDataMapper.GetAllClients();
            return View(clients);
        }

        // GET: ClientController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            Client client = new Client();
            ClientDataMapper clientDataMapper = new ClientDataMapper();

            client.Firstname = collection["Firstname"];
            client.Lastname = collection["Lastname"];
            client.Email = collection["Email"];
            client.Phone = int.Parse(collection["Phone"]);
            client.Address = collection["Address"];

            clientDataMapper.InsertClient(client);
            return RedirectToAction("Index");
        }

        // GET: ClientController1/Edit/5
        public ActionResult Edit(int id)
        {
            Client client;
            ClientDataMapper clientDataMapper = new ClientDataMapper();
            client = clientDataMapper.GetClientById(id);
            return View(client);
        }

        // POST: ClientController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Client client )
        {

            ClientDataMapper clientDataMapper = new ClientDataMapper();

            client.Firstname = collection["Firstname"];
            client.Lastname = collection["Lastname"];
            client.Email = collection["Email"];
            client.Phone = int.Parse(collection["Phone"]);
            client.Address = collection["Address"];

            clientDataMapper.UpdateClient(client);
            return RedirectToAction("Index");
        }

        // GET: ClientController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController1/Delete/5
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
