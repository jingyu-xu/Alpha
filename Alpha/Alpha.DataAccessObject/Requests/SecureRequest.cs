using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Requests
{
    public class SecureRequest : Request, ISecureRequest
    {
        public UserContext UserContext{ get; set; }
    }
}
