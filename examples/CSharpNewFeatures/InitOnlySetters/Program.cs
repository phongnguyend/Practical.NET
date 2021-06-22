/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-setters
/// </summary>

using System;

namespace InitOnlySetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User1(userName: "aaaa") { FirstName = "First" };
            //user1.UserName = "bbbb"; 

            var user2 = new User2(userName: "aaaa") { FirstName = "First" };
            //user2.UserName = "bbbb";

            var user3 = new User3 { UserName = "aaaa", FirstName = "First" };
            //user2.UserName = "bbbb";
        }
    }
}
