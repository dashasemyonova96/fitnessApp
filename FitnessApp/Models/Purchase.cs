using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
	public class Purchase
	{
		public int PurchaseId { get; set; }
		public int ClientId { get; set; }
		public virtual Client Client { get; set; } //фио клиента, который купил абонемент
		public int SubscriptionId { get; set; } //ссылка на абонемент
		public virtual Subscription Subscription { get; set; }
		public DateTime CreatedOn { get; set; }
	}
}