using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alpha.DataAccessObject.Contracts;

namespace Alpha.Web.ViewModels.WebDevelopment
{
    public class IndexViewModel
    {
        public string PageHeader { get; set; }
        public List<SubCategoryContract> SubCategories { get; set; }

        public IndexViewModel()
        {
            PageHeader = "Web Development";
        }

        public void Import(List<SubCategoryContract> subCategories)
        {
            SubCategories = subCategories;
        }
    }
}