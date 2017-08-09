using Alpha.DataAccess;
using Alpha.DataAccessObject.Contracts;
using Alpha.DataAccessObject.Enums;
using Alpha.DataAccessObject.Requests;
using Alpha.DataAccessObject.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Facade
{
    public class AccountFacade:Facade
    {
        public static ItemResponse<HomeIndexContract> GetHomeIndex()
        {
            return new AccountService().GetHomeIndex(CreateRequest<Request>());
        }

        public static ItemListResponse<SubCategoryContract> GetSubCategoryByCategoryId(CategoryTypes type)
        {            
            return new AccountService().GetSubCategoryByCategoryId(CreateItemRequest(type));
        }
    }
}
