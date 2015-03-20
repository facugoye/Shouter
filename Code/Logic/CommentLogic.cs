using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public class CommentLogic
	{
		private CommentAdapter _adapter;

		public CommentAdapter Adapter
		{
			get
			{
				if (_adapter == null)
					_adapter = new CommentAdapter();
				return _adapter; }
		}
		

		public List<Comment> GetComments()
		{
			return Adapter.GetComments();
		}

		public void InsertComment(Comment newComment)
		{
			Adapter.InsertComment(newComment);
		}
	}
}
