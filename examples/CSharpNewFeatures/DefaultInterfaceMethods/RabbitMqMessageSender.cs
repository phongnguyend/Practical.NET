using System.Threading.Tasks;

namespace DefaultInterfaceMethods
{
    public class RabbitMqMessageSender : IMessageSender
    {
        public void Send(string message)
        {

        }

        public Task SendAsync(string message)
        {
            // TODO: 
            return Task.CompletedTask;
        }
    }
}
