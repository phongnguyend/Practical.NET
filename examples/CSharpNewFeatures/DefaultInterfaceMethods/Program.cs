/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#default-interface-methods
/// </summary>

using System;
using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IMessageSender sender = new RabbitMqMessageSender();
            await sender.SendAsync("aaaa");
        }
    }
}
