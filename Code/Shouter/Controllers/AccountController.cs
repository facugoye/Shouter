using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shouter.Models;
using Logic;
using System.Web.Security;
using Shouter.Globalization;

namespace Shouter.Controllers
{
	public class AccountController : ControllerBase<AccountLogic>
	{
		[AllowAnonymous]
		public ActionResult Login()
		{
			return View(new LoginViewModel());
		}

		[HttpPost]
		[AllowAnonymous]
		public ActionResult Login(LoginViewModel model, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				if (Logic.CanLogin(new Entities.User() { email = model.Mail, password = model.Password }))
				{
					FormsAuthentication.SetAuthCookie(model.Mail, true);
					return Redirect(returnUrl ?? FormsAuthentication.DefaultUrl);					
				}
				else
					ModelState.AddModelError("", Messages.UserOrPasswordIncorrect);
			}

			return View(model);
		}

		[Authorize]
		public ActionResult LogOff()
		{
			FormsAuthentication.SignOut();
			Response.Clear();
			return RedirectToAction("LogIn");
		}
	}
}