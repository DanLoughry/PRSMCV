using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRSMVC.Models
{
	public class PurchaseRequest	{
		public int Id { get; set; }
		public string Description { get; set; }
		public string Justification { get; set; }
		public string RejectionReason { get; set; }
		public string DeliveryMode { get; set; }
		public string Status { get; set; }
		public double Total { get; set; }
		public int UserId { get; set; }

		public virtual User user { get; set; }

		public PurchaseRequest() { }
	}
}