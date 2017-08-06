using Alpha.DataAccessObject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Responses
{
    public interface IResponse
    {
        StatusTypes Status { get; set; }
        Exception Exception { get; set; }
        string ExceptionMessage { get; set; }
        int? PrimaryKey { get; set; }
        bool Success();
    }
}
