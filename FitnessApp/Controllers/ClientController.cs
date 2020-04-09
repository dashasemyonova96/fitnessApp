using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessApp.Controllers
{
    public class ClientController : Controller
    {
      
        public ActionResult Show()
        {
            var clients = FitnessContext.GetInstance().Clients;
            return View(clients);
        }

        [HttpGet]
        public ActionResult OpenProfile(int? clientId)
        {
            return View(clientId);
        }
    }
}