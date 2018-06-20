﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRSMVC.Models
{
	public class Vendor	{
		public int id { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool IsApproved { get; set; }
		public bool Active { get; set; }

		public Vendor()		{ }
	}
}