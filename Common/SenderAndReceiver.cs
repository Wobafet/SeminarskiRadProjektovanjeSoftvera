using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SenderAndReceiver
    {
    
        private NetworkStream stream;
        private BinaryFormatter formatter;

        public SenderAndReceiver(Socket s)
        {
            stream = new NetworkStream(s);
            formatter = new BinaryFormatter();
        }

        public void Send(object SendObject)
        {


                formatter.Serialize(stream,SendObject);
            


        }
        public object Receive() => formatter.Deserialize(stream);


    }
}
