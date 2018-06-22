using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4

namespace BookSale.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
<<<<<<< HEAD
        private bool isDisposed;
=======
        private bool isdisposed;

>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
        ~Disposable()
        {
            Dispose(false);
        }
<<<<<<< HEAD
=======

>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
<<<<<<< HEAD
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
=======
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
>>>>>>> a858cc096e2caa84237889930ef5ccdf417a89b4
