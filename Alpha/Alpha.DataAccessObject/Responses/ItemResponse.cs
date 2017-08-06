using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Responses
{
    public class ItemResponse<T>: Response
    {
        public T Item { get; set; }
    }
}
