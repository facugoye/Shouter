using Shouter.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shouter.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType= typeof(Messages))]
		[Display(Name = "Mail", ResourceType=typeof(Labels))]
		[EmailAddress(ErrorMessageResourceName = "InvalidMailAddress", ErrorMessageResourceType= typeof(Messages), ErrorMessage=null)]
		public string Mail { get; set; }

		[Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType=typeof(Messages))]
		[DataType(DataType.Password)]
		[Display(Name="Password", ResourceType = typeof(Labels))]
		public string Password { get; set; }
	}
}