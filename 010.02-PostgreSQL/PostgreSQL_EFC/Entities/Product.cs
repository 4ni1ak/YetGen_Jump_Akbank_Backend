﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL_EFC.Entities
{
	public class Product
	{

		public Guid Id { get; set; }
		public string Title { get; set; }
		public decimal Weight { get; set; }
		public decimal Price { get; set; }
		
		public Product(string title, decimal weight, decimal price)
		{
			Id = Guid.NewGuid();
			Title = title;
			Weight = weight;
			Price = price;
		}
	}
}