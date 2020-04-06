using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
	public class Client
	{
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Sex { get; set; }
		public DateTime Birthday { get; set; }
		public string MobilePhone { get; set; }
	}
}