using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public interface IMessageSender
    {
        void Send(string message);

        Task SendAsync(string message)
        {
            Send(message);
            return Task.CompletedTask;
        }
    }
}
