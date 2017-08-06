using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alpha.DataAccessObject.Enums;

namespace Alpha.DataAccessObject.Responses
{
    public class Response : IResponse
    {
        public Exception Exception { get; set; }
        public string ExceptionMessage { get; set; }
        public int? PrimaryKey { get; set; }
        public StatusTypes Status { get; set; }

        public bool Success()
        {
            return (int)Status >= 1000 && (int)Status < 3000;
        }
    }
}
