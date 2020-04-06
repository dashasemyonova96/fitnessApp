using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FitnessApp.Models
{
	public class ClientContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }
	}

	public class ClientDbInitializer : DropCreateDatabaseAlways<ClientContext>
	{
		protected override void Seed(ClientContext context)
		{
			context.Clients.Add(new Client
			{
				FirstName = "Дарья",
				MiddleName = "Александровна",
				LastName = "Семёнова",
				Sex = "Woman",
				Birthday = new DateTime(1996, 11, 30, 0, 0, 0),
				MobilePhone = "+375257363169"
			});

			context.Clients.Add(new Client
			{
				FirstName = "Дмитрий",
				MiddleName = "Викторович",
				LastName = "Мизерник",
				Sex = "Man",
				Birthday = new DateTime(1996, 11, 30, 0, 0, 0),
				MobilePhone = "+375299457812"
			});

			base.Seed(context);
		}
	}
}