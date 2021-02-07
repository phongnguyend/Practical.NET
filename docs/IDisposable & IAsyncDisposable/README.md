## Docs:
- [Implement a Dispose method | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose)
- [Implement a DisposeAsync method | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync)
- [Using objects that implement IDisposable | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/using-objects)

## Samples:
```c#
    public class DisposableClass : IDisposable
    {
        ~DisposableClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TODO: dispose managed resources
            }

            // TODO: dispose unmanaged resources
        }
    }

    public class InheritedDisposableClass : DisposableClass
    {
        ~InheritedDisposableClass()
        {
            Dispose(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // TODO: dispose managed resources
            }

            // TODO: dispose unmanaged resources

            base.Dispose(disposing);
        }
    }
```
