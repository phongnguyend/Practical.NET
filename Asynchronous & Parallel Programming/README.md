
- I/O Operations
- async/ await
- Task
- Task Continuation
  + ContinueWith
  + ConfigureAwait
    + Not applicable for .Net Core
    + Shoule use ConfigureAwait(false) when writing libraries
- Task Cancellation
- Task Completion
  + When All
  + When Any
- Task.Delay vs Thread.Sleep
