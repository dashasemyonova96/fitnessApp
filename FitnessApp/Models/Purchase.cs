using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
	public class Purchase
	{
		public int PurchaseId { get; set; }
		public string Person { get; set; } //фио клиента, который купил абонемент
		public int SubscriptionId { get; set; } //ссылка на абонемент
		//public virtual Subscription Subscription { get; set; }		
		public DateTime Date { get; set; }
	}
}