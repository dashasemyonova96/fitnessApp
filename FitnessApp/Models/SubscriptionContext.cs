using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FitnessApp.Models
{
	/* Взаимодействуем с БД через Entity Framework. 
	 * Для этого нужен контекст данных. Поэтому созждаем класс SubscriptionContext.
	 * У нас есть 2 модели, каждая будет храниться в своей таблице.
	 * В web.config указать connectionStrings.
	*/
	public class SubscriptionContext : DbContext
	{
		public SubscriptionContext() : base("DefaultConnection")
		{ }
		public DbSet<Subscription> Subscriptions { get; set; } //свойство типа DbSet (типизировано моделью Subscription)
		public DbSet<Purchase> Purchases { get; set; }

		/* Подходы EF:
		 * Database First
		 * Code First - если бд не существует, то она будет создана при первом к ней обращении
		 */
	}

	/* Инициализаторы баз данных используются, чтобы добавить в бд некоторые начальные данные.
	 * Мы должны запустить инициализатор при старте приложения (Global.asax)
	 */
	public class SubscriptionDbInitializer : DropCreateDatabaseAlways<SubscriptionContext> //типизирован классом контекста. 
		//При каждом запуске пересоздает бд
	{
		protected override void Seed(SubscriptionContext context)
		{
			context.Subscriptions.Add(new Subscription { Name = "Студенческий", Price = 50, AmountDays = 30, PauseDays = 3 });
			context.Subscriptions.Add(new Subscription { Name = "Базовый", Price = 100, AmountDays = 30, PauseDays = 3 });
			context.Subscriptions.Add(new Subscription { Name = "VIP", Price = 200, AmountDays = 30, PauseDays = 10 });

			base.Seed(context);
		}
	}

}