using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shouter.Models
{
	public class CommentsViewModel
	{
		public CommentsViewModel()
		{
			Comments = new List<CommentViewModel>();
		}

		/// <summary>
		/// Encapsula el comentario actual que se esta queriendo guardar
		/// </summary>
		public CommentViewModel Comment { get; set; }

		/// <summary>
		/// Encapsula los comentarios ya guardados para mostrarlos en una lista
		/// </summary>
		public List<CommentViewModel> Comments { get; set; }
	}
}