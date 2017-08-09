using Alpha.Facade;
using Alpha.Web.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpha.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var vm = new IndexViewModel();
            //GET data from database            
            var response = AccountFacade.GetHomeIndex();
            //do exception check
            if(response.Success())
            {
                vm.Import(response.Item);
            }
            //put data into viewmodel

            //return
            return View(vm);
        }       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}