using Alpha.DataAccessObject.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alpha.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public string PageHeader { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public List<CategoryContract> Categories { get; set; }
        public IndexViewModel()
        {
            PageHeader = "Home Page";
        }

        public void Import(HomeIndexContract contract)
        {
            Name = contract.PersonalInfo.Name;
            Position = contract.PersonalInfo.CurrentPosition;
            Categories = contract.Categories.ToList();
        }
    }
}