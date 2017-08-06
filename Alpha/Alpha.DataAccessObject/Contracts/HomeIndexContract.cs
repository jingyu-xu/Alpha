using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Contracts
{
   public  class HomeIndexContract
    {
        public List<CategoryContract> Categories { get; set; } = new List<CategoryContract>();
        public PersonalInfoContract PersonalInfo { get; set; } = new PersonalInfoContract();
    }
}
