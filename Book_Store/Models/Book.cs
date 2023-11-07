using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
	public class Book
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public int Year { get; set; }

		public int AuthorId { get; set; }
		public Author Author { get; set; }
	}
}

