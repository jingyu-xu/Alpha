using Alpha.Data;
using Alpha.DataAccessObject.Requests;
using Alpha.DataAccessObject.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccess.Common
{
    public class ActionData<TRequest, TResponse> where TRequest:IRequest where TResponse:IResponse, new()
    {
        public TRequest Request { get; set; }
        public TResponse Response { get; set; }
        public AlphaEntities Entities { get; set; }

        public ActionData(TRequest request)
        {
            Response = new TResponse();
            Request = request;
        }       
    }
}
