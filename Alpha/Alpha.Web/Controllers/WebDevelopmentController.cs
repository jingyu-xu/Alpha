using Alpha.Facade;
using Alpha.Web.ViewModels.WebDevelopment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpha.Web.Controllers
{
    public class WebDevelopmentController : Controller
    {
        // GET: WebDevelopment
        public ActionResult Index()
        {
            var vm = new IndexViewModel();
            // Get Data From DataBase
            var response = AccountFacade.GetSubCategoryByCategoryId(DataAccessObject.Enums.CategoryTypes.WebDevelopment);
            // Do Exception Check
            if(response.Success())
            {
                vm.Import(response.Items);
            }
            // Put data on ViewModel
            return View(vm);
        }
    }
}