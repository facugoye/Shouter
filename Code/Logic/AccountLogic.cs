using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class AccountLogic
	{
		private AccountAdapter adapter;

		public AccountAdapter Adapter
		{
			get
			{
				if (adapter == null)
					adapter = new AccountAdapter();
				return adapter;
			}
		}


		public Boolean CanLogin(User user)
		{
			var email = user.email;
			var password = user.password;
			if (email != "" && password != "")
			{
				var currentUser = Adapter.GetUser(email);

				return (currentUser != null
					&& currentUser.email == email
					&& currentUser.password == password);
			}
			return false;
		}
	}
}
