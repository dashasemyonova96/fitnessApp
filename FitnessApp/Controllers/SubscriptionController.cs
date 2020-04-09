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
		public ActionResult Show()
		{
			var subscriptions = FitnessContext.GetInstance().Subscriptions;
			return View(subscriptions);

			/* Subscriptions - свойство, определенное в классе контекста данных.
				Получили все объекты из таблицы Subscriptions. 
				Передаем их в представление
			*/

			//ViewBag.Subscr = subscriptions;
			/* ViewBag - динамический объект, в котором мы можем определить любые переменные и вложить в них
			 * любое содержимое.
			 * Определим переменную Subscr и присвоим ей список полученных абонементов
			*/

		}

		[HttpGet]
		public ActionResult OpenInformation(int? subscriptionId)
		{
			return View(subscriptionId);
		}
	}
}