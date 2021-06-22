/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#fit-and-finish-features
/// </summary>

using System;

namespace TargetTypedNewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User() { FirstName = "First" };
            User user2 = new() { FirstName = "First" };
            var message = CreateUserMessage(user1, metaData: new());
        }

        static Message<User> CreateUserMessage(User user, MetaData metaData)
        {
            return new() { Data = user, MetaData = metaData };
        }
    }
}
