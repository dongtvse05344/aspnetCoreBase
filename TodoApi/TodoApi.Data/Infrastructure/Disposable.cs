using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Ovveride this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}
