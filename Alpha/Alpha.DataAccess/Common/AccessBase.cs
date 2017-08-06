using Alpha.Data;
using Alpha.DataAccessObject;
using Alpha.DataAccessObject.Enums;
using Alpha.DataAccessObject.Requests;
using Alpha.DataAccessObject.Responses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.DataAccess.Common
{
    public abstract class AccessBase
    {
        protected static TResponse PerfomeGet<TRequest, TResponse>(TRequest request, Action<ActionData<TRequest, TResponse>> action)
            where TRequest : IRequest where TResponse : IResponse, new()
        {
            return Perform(request, true, action);
        }

        protected static TResponse PerfomeCUD<TRequest, TResponse>(TRequest request, Action<ActionData<TRequest, TResponse>> action)
            where TRequest : IRequest where TResponse : IResponse, new()
        {
            return Perform(request, false, action);
        }

        protected static async Task<TResponse> PerformGetAsync<TRequest, TResponse>(TRequest request, Func<ActionData<TRequest, TResponse>, Task> action)
            where TRequest : IRequest where TResponse : IResponse, new()
        {
            return await PerformAsync(request, true, action);
        }

        protected static async Task<TResponse> PerformCUDAsync<TRequest, TResponse>(TRequest request, Func<ActionData<TRequest, TResponse>, Task> action)
            where TRequest : IRequest where TResponse : IResponse, new()
        {
            return await PerformAsync(request, false, action);
        }

        private static TResponse Perform<TRequest, TResponse>(TRequest request, bool IsGet, Action<ActionData<TRequest, TResponse>> action)
            where TRequest:IRequest where TResponse:IResponse, new()
        {
            if (action == null) throw new ArgumentNullException("action");
            if (request == null) throw new ArgumentNullException("request");

            var data = new ActionData<TRequest, TResponse>(request);
            UserContext UserContext = null;
            if (request is ISecureRequest) UserContext = (request as ISecureRequest).UserContext;

            using(data.Entities = new AlphaEntities())
            {
                try
                {
                    action(data);
                    if(data.Response.Exception != null)
                    {
                        //Do Log Exception
                    }
                    if(NeedAudit(data.Response.Status))
                    {
                        //Do Log Audit
                    }
                    if(!IsGet && IsSuccess(data.Response.Status))
                    {
                        var changedEntity = request is IAddRequest ?
                                                data.Entities.ChangeTracker.Entries()
                                                    .Where(n => n.Entity.GetType() == (data.Request as IAddRequest).Type)
                                                    .Where(n => n.State == EntityState.Added)
                                                    .Select(n => new { n.State, n.Entity })
                                                    .OrderBy(n => n.State)
                                                    .Select(n => n.Entity)
                                                    .FirstOrDefault() : null;
                        data.Entities.SaveChanges();
                        if (changedEntity != null)
                        {
                            data.Response.PrimaryKey = changedEntity.GetType().GetProperty((data.Request as IAddRequest).PrimaryKey).GetValue(changedEntity) as int?;
                        }
                    }
                }
                catch(Exception e)
                {

                }
            }

            return data.Response;
        }

        private static async Task<TResponse> PerformAsync<TRequest, TResponse>(TRequest request, bool IsGet, Func<ActionData<TRequest, TResponse>, Task> action)
            where TRequest : IRequest where TResponse : IResponse, new()
        {
            if (action == null) throw new ArgumentNullException("action");
            if (request == null) throw new ArgumentNullException("request");

            var data = new ActionData<TRequest, TResponse>(request);
            UserContext UserContext = null;
            if (request is ISecureRequest) UserContext = (request as ISecureRequest).UserContext;

            using (data.Entities = new AlphaEntities())
            {
                try
                {
                    await action(data);
                    if (data.Response.Exception != null)
                    {
                        //Do Log Exception
                    }
                    if (NeedAudit(data.Response.Status))
                    {
                        //Do Log Audit
                    }
                    if (!IsGet && IsSuccess(data.Response.Status))
                    {
                        var changedEntity = request is IAddRequest ?
                                                data.Entities.ChangeTracker.Entries()
                                                    .Where(n => n.Entity.GetType() == (data.Request as IAddRequest).Type)
                                                    .Where(n => n.State == EntityState.Added)
                                                    .Select(n => new { n.State, n.Entity })
                                                    .OrderBy(n => n.State)
                                                    .Select(n => n.Entity)
                                                    .FirstOrDefault() : null;
                        await data.Entities.SaveChangesAsync();
                        if (changedEntity != null)
                        {
                            data.Response.PrimaryKey = changedEntity.GetType().GetProperty((data.Request as IAddRequest).PrimaryKey).GetValue(changedEntity) as int?;
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }

            return data.Response;
        }


        private static bool IsSuccess(StatusTypes type)
        {
            return (int)type >= 1000 && (int)type < 2000;
        }   
        
        private static bool NeedAudit(StatusTypes type)
        {
            return (int)type >= 2000 && (int)type < 4000;
        }         
    }
}
