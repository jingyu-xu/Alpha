using Alpha.DataAccessObject;
using Alpha.DataAccessObject.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Facade
{
    public abstract class Facade
    {
        protected static TRequest CreateRequest<TRequest>() where TRequest : IRequest, new() => new TRequest();

        protected static ItemRequest<TItem> CreateItemRequest<TItem>(TItem item)
        {
            var request = CreateRequest<ItemRequest<TItem>>();
            request.Item = item;
            return request;
        }

        protected static TRequest CreateSecureRequest<TRequest>(UserContext context)
            where TRequest: SecureRequest, new()
        {
            if (context == null) throw new ArgumentNullException("context");
            var request = CreateRequest<TRequest>();
            request.UserContext = context;
            return request;
        }

        protected static SecureItemRequest<TItem> CreateSecureItemRequest<TItem>(TItem item, UserContext context)
        {
            var request = CreateSecureRequest<SecureItemRequest<TItem>>(context);
            request.Item = item;
            return request;
        }

        protected static SecureItemAddRequest<TItem> CreateSecureItemAddRequest<TItem>(TItem item, Type type, string primaryKey, UserContext context)
        {
            var request = CreateSecureRequest<SecureItemAddRequest<TItem>>(context);
            request.Type = type;
            request.PrimaryKey = primaryKey;
            request.Item = item;
            return request;
        }
    }
}
