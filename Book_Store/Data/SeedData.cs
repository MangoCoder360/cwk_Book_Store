using System;
using Book_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Data
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new AppDBContext(serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>()))
			{
				if (context.Books.Any())
				{
					return;
				}
				context.Books.AddRange(
					new Book
					{
						Name = "Fake Book",
						Year = 2000
					},
                    new Book
                    {
                        Name = "Fake Book 2",
                        Year = 2010
                    },
                    new Book
                    {
                        Name = "Fake Book 3",
                        Year = 2023
                    }
                );
				context.SaveChanges();
			}
		}
	}
}