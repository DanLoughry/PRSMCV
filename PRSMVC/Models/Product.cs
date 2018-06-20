﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRSMVC.Models
{
	public class Product	{
		public int id { get; set; }
		public string PartNumber { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Unit { get; set; }
		public string Photopath { get; set; }
		public int VendorId { get; set; }

		public virtual Vendor Vendor { get; set; }

		public Product() { }
	}
}