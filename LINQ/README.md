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

 ## LINQ to XML
 - System.Xml.Linq
 - XDocument
 - XElement
 - XAttribute
 - XNamespace
 
 ## LINQ to Entity Framework
 - IQueryable vs IEnumerable
 - Expression<Func<>> vs Func<>
 - Be careful which type you are writting the query on
   + Beside IEnumerable Deferred Execution Pitfalls, you might get more data than you need (you might load entire data related to the query into memory before applying filtering) -> watch out for the database statement generated
   + Not every expression can be translated to database statement, exception will be thrown at runtime, in some cases expression will be evaluated in memory after loading data into memory first -> again, always watch out for the generated statement
 
