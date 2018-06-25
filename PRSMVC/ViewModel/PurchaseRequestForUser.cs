using PRSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRSMVC.ModelView
{
	public class PurchaseRequestForUser	{

		public User User { get; set; }
		public IEnumerable<PurchaseRequest> PurchaseRequests { get; set; }

		public PurchaseRequestForUser() { }



	}
}