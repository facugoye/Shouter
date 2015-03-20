using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Comment
	{
		public Int32 ID { get; set; }

		[Required]
		public string email { get; set; }

		[Required]
		public DateTime dateTime { get; set; }

		[Required]
		public string comment { get; set; }
	}
}
