using System.Net.Sockets;

namespace Server.Listeners
{
    public interface ITcpListener
    {
        public TcpClient Accept();

        public void Close();
    }
}
