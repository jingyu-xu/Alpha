using Alpha.DataAccess.Common;
using Alpha.DataAccessObject.Contracts;
using Alpha.DataAccessObject.Enums;
using Alpha.DataAccessObject.Requests;
using Alpha.DataAccessObject.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccess
{
    public class AccountService: AccessBase
    {
        public ItemResponse<HomeIndexContract> GetHomeIndex(Request request) => 
            PerfomeGet<Request, ItemResponse<HomeIndexContract>>(request, (data) => {
                data.Response.Item = new HomeIndexContract();
                data.Response.Item.Categories = data.Entities.Categories.Select(n => new CategoryContract() { CategoryId = n.CategoryId, Description = n.Description }).ToList();
                data.Response.Item.PersonalInfo = new PersonalInfoContract() { Name = "Jingyu Xu", CurrentPosition = "Student" };
                data.Response.Status = StatusTypes.Success;
            });
    }
}
