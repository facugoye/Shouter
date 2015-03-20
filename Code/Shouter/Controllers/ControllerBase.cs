using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shouter.Controllers
{
	public class ControllerBase<L> : Controller
		where L : new()
	{
		private L _logic;

		public L Logic
		{
			get {
				if (_logic == null)
					_logic = new L();
				return _logic; }
		}
		
	}
}