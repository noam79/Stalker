using System.Net.Sockets;

namespace Server.ClientHandlers
{
    public interface ITcpClientHandler
    {
        public void HandleClient(TcpClient client);

        public void Close();
    }
}
