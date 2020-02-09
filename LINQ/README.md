## C# Features That LINQ Relies On
- IEnumerable
- Generic
- Extension Method
- Delegate
  + Func
  + Action
  + Named method
  + Anonymous method
  + Lambda Expression
- Deferred Execution (Yield Return)
  + Advantages:
    + Return only what is realy needed. Ex: Take()
    + Build query structure only and decide to use later somewhere else in the source code
  + Pitfalls:
    + Can be executed twice or even more if don't pay enough attention
    + Catch exception in wrong place
  + [Streaming vs Non-streaming Executions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/classification-of-standard-query-operators-by-manner-of-execution)
- More about [C# Features That Support LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/features-that-support-linq)
  
 ## LINQ Fundamentals
 - Query syntax vs Method syntax
 - Filtering
   + Where()
   + Skip()
   + Take()
   + First()
   + FirstOrDefault()
   + Last()
   + LastOrDefault()
   + Single()
   + SingleOrDefault()
 - Sorting (Ordering)
   + OrderBy()
   + OrderByDescending()
   + ThenBy()
   + ThenByDescending()
 - Projecting (Selecting, Transforming)
   + Select()
 - Quantifying
   + Any()
   + All()
   + Contains()
- Flattening
  + SelectMany()
- Joining
  + Join()
  + Joining condition on single field
  + Joining condition on multiple fields (Composite Key)
  + GroupJoin()
- Grouping
  + Group()
- Aggregating()
  + Count()
  + Min()
  + Max()
  + Average()
  + Sum()
  + Aggregate()
