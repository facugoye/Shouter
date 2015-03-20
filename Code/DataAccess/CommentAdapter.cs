using Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class CommentAdapter
	{
		public List<Comment> GetComments()
		{
			MongoDatabase db = DBConnection.Db();
			var comments = db.GetCollection<CommentMongo>("comments");
			MongoDB.Driver.Builders.SortByBuilder sort = new MongoDB.Driver.Builders.SortByBuilder();
			sort.Descending("dateTime");

			return comments.FindAll().SetSortOrder(sort).ToList<Comment>();

			//return default(List<Comment>);
		}

		public void InsertComment(Comment newComment)
		{
			MongoDatabase db = DBConnection.Db();
			if (!db.CollectionExists("comments"))
				db.CreateCollection("comments");
			var comments = db.GetCollection("comments");

			var commentObject = new BsonDocument();
			commentObject["email"] = newComment.email;
			commentObject["comment"] = newComment.comment;
			commentObject["dateTime"] = DateTime.Now;
			comments.Insert(commentObject);
		}

		private class CommentMongo : Comment
		{
			public ObjectId _id { get; set; }		
		}
	}

}
