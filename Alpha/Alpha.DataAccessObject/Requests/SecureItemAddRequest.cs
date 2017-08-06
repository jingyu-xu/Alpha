using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Requests
{
    public class SecureItemAddRequest<T> : SecureItemRequest<T>, IAddRequest
    {
        public string PrimaryKey { get; set; }
        public Type Type { get; set; }
    }
}
