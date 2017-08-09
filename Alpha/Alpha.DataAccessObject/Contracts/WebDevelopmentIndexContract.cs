using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Contracts
{
    public class WebDevelopmentIndexContract
    {
        public List<SubCategoryContract> SubCategories { get; set; } = new List<SubCategoryContract>();
    }
}
