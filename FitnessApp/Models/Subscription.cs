using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
	public class Subscription // абонемент
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int AmountDays { get; set; }
		public int PauseDays { get; set; }
		public virtual ICollection<Purchase> Purchases { get; set; }
	}
}