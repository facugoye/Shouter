using Entities;
using Logic;
using Shouter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shouter.Controllers
{
    public class CommentsController : ControllerBase<CommentLogic>
    {
		//
		// GET: /Comments/
		[Authorize]
		public ActionResult Index()
		{

			var vm = new CommentsViewModel() {};

			Logic.GetComments().ForEach(c => {
				vm.Comments.Add(new CommentViewModel(){
					Comment = c.comment,
					Date = c.dateTime,
					User = c.email
				});
			});

			return View(vm);
		}

		[HttpPost]
		[Authorize]
		public ActionResult InsertNewComment(CommentViewModel vm)
		{
			vm.Date = DateTime.Now;
			vm.User = HttpContext.User.Identity.Name;

			if (ModelState.IsValid)
			{
				Comment newComment = new Comment()
				{
					email = vm.User,
					comment = vm.Comment,
					dateTime = vm.Date
				};

				Logic.InsertComment(newComment);
			}
			return PartialView("CommentItem", vm);
		}
    }
}