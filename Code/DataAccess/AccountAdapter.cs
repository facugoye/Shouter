using Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class AccountAdapter
	{
		public User GetUser(String userName)
		{
			MongoDatabase db = DBConnection.Db();
			var users = db.GetCollection("users");
			var query = new QueryDocument("email", userName);
			var currentUser = users.FindOne(query);

			if (currentUser != null)
				return new User()
				{
					email = currentUser["email"].ToString(),
					password = currentUser["password"].ToString()
				};

			return null;
		}
	}
}
