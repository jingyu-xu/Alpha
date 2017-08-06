using Alpha.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpha.Web.Controllers
{
    public class BaseController : Controller
    {
        public UserContext UserContext
        {
            get
            {
                UserContext context = Session["UserContext"] as UserContext;
                if(context == null && User.Identity.IsAuthenticated)
                {
                    //refresh UserContext
                }
                return context;
            }
            set { Session["UserContext"] = value; }
        }
    }
}