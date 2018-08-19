using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlexMVCApp.Models {
	public class Carrier {
		public int CarrierID { get; set; }
		[MaxLength(50)]
		public string MCNumber { get; set; }
		public int DOTNumber { get; set; }

	}
}