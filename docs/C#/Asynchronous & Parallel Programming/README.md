### Concurrency vs. Parallelism
- [Concurrency vs. Parallelism](https://jenkov.com/tutorials/java-concurrency/concurrency-vs-parallelism.html)
- [language agnostic - What is the difference between concurrency and parallelism? - Stack Overflow](https://stackoverflow.com/questions/1050222/what-is-the-difference-between-concurrency-and-parallelism)

### Asynchronous vs. Parallel Programming
- [Asynchronous and Parallel Programming](https://www.c-sharpcorner.com/uploadfile/bc1c71/asynchronous-and-parallel-programming/)
- [c# - What is the difference between asynchronous programming and multithreading? - Stack Overflow](https://stackoverflow.com/questions/34680985/what-is-the-difference-between-asynchronous-programming-and-multithreading)
- [There Is No Thread](https://blog.stephencleary.com/2013/11/there-is-no-thread.html)

## Docs:
- [Managed Threading in .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/threading/)
- [Parallel Programming in .NET | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/)
- [Asynchronous programming in C# | Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/)
- [Async/Await - Best Practices in Asynchronous Programming | Microsoft Docs](https://docs.microsoft.com/en-us/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)

## Asynchronous Programming
- I/O Operations
  + Disk
  + Memory
  + Web/API
  + Database
- async/await
  + The await keyword:
    + Introduces a continuation, allowing us to get back to the original context (thread)
    + Gives us a potential result
    + Validates the success or failure of the operation
    + Continuation is back on calling thread
  + Should not use async void, it is only appropriate for event handlers (use async Task instead)
  + Exceptions occurring in an async void method cannot be caught
  + Using async and await in Asp.Net means the web server can handle other requests
  + Best Practices:
    + Never use async void unless it's an event handler or delegate
    + Never block an asynchronous operation by calling Result or Wait() *([Don't Block on Async Code](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html))*
    + Always use async and await together
    + Always return a Task from an asynchronous method
    + Always await an asynchronous method to validate the operation
    + Use async and await all the way up the chain
  + More:
    + [Async and Await](https://blog.stephencleary.com/2012/02/async-and-await.html)
    + [Async/Await FAQ - .NET Parallel Programming](https://devblogs.microsoft.com/pfxteam/asyncawait-faq/)
- [Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
  + Task is a reference to an asynchronous operation
  + Work passed to Task.Run() is scheduled to execute on a different thread
  + Tasks swallow exceptions
  + Continuations are executed on a different thread
  + Wrapping synchronous code in Task.Run() can be dangerous. Make sure there is no blocking code.
- Task Continuation
  + Obtaining the Result of a Task
  + Handling Success or Failure
  + Validate Tasks even when not using async and await by chaining on a continuation
  + ContinueWith()
    + ContinueWith() vs await
    + [c# - Difference between await and ContinueWith - Stack Overflow](https://stackoverflow.com/questions/18965200/difference-between-await-and-continuewith)
    + [Difference Between Await and ContinueWith Keyword in C#](https://www.c-sharpcorner.com/UploadFile/pranayamr/difference-between-await-and-continuewith-keyword-in-C-Sharp/)
  + ConfigureAwait()
    + ConfigureAwait(false) should be used when we don't care about the original context
    + Shoule use ConfigureAwait(false) when writing libraries
    + [ConfigureAwait FAQ | .NET Blog](https://devblogs.microsoft.com/dotnet/configureawait-faq/)
    + [ASP.NET Core SynchronizationContext](https://blog.stephencleary.com/2017/03/aspnetcore-synchronization-context.html)
- Task Cancellation
- Task Completion
  + Getting Result or Exception from a Task
  + Task.WhenAll()
  + Task.WhenAny()
- Task.Delay() vs Thread.Sleep()
- [ValueTask](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1)
  + [Understanding the Whys, Whats, and Whens of ValueTask - .NET Blog](https://devblogs.microsoft.com/dotnet/understanding-the-whys-whats-and-whens-of-valuetask/)
  + [asynchronous - Why would one use Task<T> over ValueTask<T> in C#? - Stack Overflow](https://stackoverflow.com/questions/43000520/why-would-one-use-taskt-over-valuetaskt-in-c)
  + [Async ValueTask Pooling in .NET 5 - .NET Blog](https://devblogs.microsoft.com/dotnet/async-valuetask-pooling-in-net-5/)

## Parallel Programming
- Parallel programming lets us break down a large problem and compute each piece independently
- When to use Parallel Programming
  + CPU bound operations
  + Independent checks of data
- Parallel Programming in .NET
  + Thread
  + Task Parallel Library
  + Parallel Extensions
  + Parallel LINQ
- Notice: Misusing parallel principles in Asp.Net can cause bad performance for all users
- Processing a collection of data in parallel
  + [Parallel Class](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.parallel)
  + Parallel.Invoke()
  + Parallel.For()
  + Parallel.ForEach()
- Working with Shared Variables and Collections
  + Locking
  + Concurrent Collections
  
## Advanced Topics
- Code generated by async and await
  + [Async Await and the Generated StateMachine - CodeProject](https://www.codeproject.com/Articles/535635/Async-Await-and-the-Generated-StateMachine)
  + [C# async await explained - NDepend](https://blog.ndepend.com/c-async-await-explained/)
  + [How Async/Await Really Works in C# - .NET Blog](https://devblogs.microsoft.com/dotnet/how-async-await-really-works/)
- State Machine
  + Keeps track of tasks
  + Executes the continuation with a potential result
  + Ensures the continuation executes on the correct context
  + Handles context switching
  + Reports errors
- Deadlocking
  + [Don't Block on Async Code](https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html)
  + [Should I expose synchronous wrappers for asynchronous methods? - .NET Parallel Programming](https://devblogs.microsoft.com/pfxteam/should-i-expose-synchronous-wrappers-for-asynchronous-methods/)
- Reporting on progress of a Task
  + IProgress<T>
- Using Task Completion Source
  + Wrapping legacy code
- Child/Parent Tasks
  + Attached and Detached Tasks
- Asynchronous Streams
