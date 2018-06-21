using System.IO;
using System.Net.Sockets;

namespace NEJC_Inc
{
    class netcat
    {
        private NetworkStream stream;
        private StreamWriter streamw;
        private StreamReader streamr;
        private TcpClient myclient = new TcpClient();
        public void connect(string host, int port)
        {
            myclient.Connect(host, port);
            stream = myclient.GetStream();
            streamw = new StreamWriter(stream);
            streamr = new StreamReader(stream);
        }
        public void client_send(string text)
        {
            streamw.WriteLine(text);
            streamw.Flush();
        }
        public string client_receive()
        {
            return streamr.ReadLine();
        }
    }

}
