using System;

namespace BookSale.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isdisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isdisposed && disposing)
            {
                DisposeCore();
            }
            isdisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}