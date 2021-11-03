### Memory Management:
- [What is managed code? | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/managed-code)
- [Automatic Memory Management | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/automatic-memory-management)

### Cleaning up unmanaged resources:
- [Implement a Dispose method | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose)
- [Implement a DisposeAsync method | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-disposeasync)
- [Using objects that implement IDisposable | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/using-objects)

#### Samples:
```c#
    // Implement IDisposable if you use IDisposable objects as instance fields
    // Implement IDisposable if you use unmanaged resources as instance fields
    public class DisposableClass : IDisposable
    {
        // Only if you use unmanaged resources
        //~DisposableClass()
        //{
        //    Dispose(false);
        //}

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
        // Only if you use unmanaged resources
        //~InheritedDisposableClass()
        //{
        //    Dispose(false);
        //}

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

### Garbage Collection:
- [.NET garbage collection | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/)
- [Fundamentals of garbage collection | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/fundamentals)
- [Garbage Collection and Performance | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/performance)

###
