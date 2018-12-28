using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TodoContext Init();
    }

    public class DbFactory : Disposable, IDbFactory
    {
        TodoContext dbContext;

        public TodoContext Init()
        {
            return dbContext ?? (dbContext = new TodoContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
