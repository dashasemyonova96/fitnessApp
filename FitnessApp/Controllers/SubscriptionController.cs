using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessApp.Controllers
{
    public class SubscriptionController : Controller
    {
		SubscriptionContext db = new SubscriptionContext();
		public ActionResult Show()
		{
			var subscriptions = db.Subscriptions;
			/* Subscriptions - свойство, определенное в классе контекста данных.
				Получили все объекты из таблицы Subscriptions. 
				Передаем их в представление
			*/

			//ViewBag.Subscr = subscriptions;
			/* ViewBag - динамический объект, в котором мы можем определить любые переменные и вложить в них
			 * любое содержимое.
			 * Определим переменную Subscr и присвоим ей список полученных абонементов
			*/
			return View(subscriptions);
		}

		public ActionResult Buy(int? subscriptionId)
		{
			return View(subscriptionId);
		}

		[HttpPost]
		public string Buy(Purchase purchase)
		{
			purchase.Date = DateTime.Now;
			db.Purchases.Add(purchase);
			db.SaveChanges();
			return "Спасибо, " + purchase.Person + ", за покупку!";
		}
	}
}