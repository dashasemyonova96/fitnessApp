using FitnessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessApp.Controllers
{
	public class HomeController : Controller
	{
		SubscriptionContext db = new SubscriptionContext();
		public ActionResult Index() //Буду использовать для вывода всех абонементов на страницу
		{
			var subscriptions = db.Subscriptions;
			/* Subscriptions - свойство, определенное в классе контекста данных.
				Получили все объекты из таблицы Subscriptions. 
				Передаем их в представление
			*/

			ViewBag.Subscr = subscriptions;
			/* ViewBag - динамический объект, в котором мы можем определить любые переменные и вложить в них
			 * любое содержимое.
			 * Определим переменную Subscr и присвоим ей список полученных абонементов
			*/
			return View();
		}
	}
}