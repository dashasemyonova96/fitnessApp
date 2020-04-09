using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessApp.Models
{
	public enum Sex 
	{ 
		Male,
		Female
	}

	public enum HealthGroup
	{
		First = 1,
		Second,
		Third
	}
	public class Client
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public Sex Sex { get; set; }
		public DateTime Birthday { get; set; }
		public string MobilePhone { get; set; }
		public bool HasViber { get; set; }
		public bool HasTelegram { get; set; }
		public bool HasWhatsapp { get; set; }
		public string Email { get; set; }
		public HealthGroup HealthGroup { get; set; }
		public double Height { get; set; }
		public double Цeight { get; set; }


	}
}