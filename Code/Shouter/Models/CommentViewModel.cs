using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shouter.Models
{
	public class CommentViewModel
	{
		[Required]
		public String Comment { get; set; }
		public String User { get; set; }
		public DateTime Date { get; set; }
	}
}