using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccessObject.Responses
{
    public class ItemListResponse<T>:Response
    {
        public List<T> Items { get; set; } = new List<T>();
    }
}
