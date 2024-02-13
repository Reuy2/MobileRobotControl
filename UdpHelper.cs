using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.Json.Serialization;

namespace _5sem_Lab1UDP
{
    internal class UdpHelper : IDisposable
    {
        IPAddress addr;

        int serverPort;
        int clientPort;
        int numberOfCommand = 0;

        IPEndPoint remoteEndPoint;

        bool isRecievingActive = false;

        UdpClient udpClient;

        string newReceivedMessage = "";
        string newTranslatedMessage = "";


        public void Dispose()
        {
            StopRecievingMessages();
            udpClient.Dispose();
            newReceivedMessage = "";
            newTranslatedMessage = "";
        }


        public UdpHelper(IPAddress addr, int serverPort, int clientPort)
        {
            this.addr = addr;
            this.serverPort = serverPort;
            this.clientPort = clientPort;
            udpClient = new UdpClient(serverPort);
            remoteEndPoint = new IPEndPoint(addr, clientPort);
            numberOfCommand = 0;
        }

        public string NewTranslatedMessage { get { return newTranslatedMessage; } set { newTranslatedMessage = value; } }
        public string NewReceivedMessage { get { return newReceivedMessage; } set { newReceivedMessage = value; } }

        async public void StartRecievingMessage()
        {
            isRecievingActive = true;
            while (isRecievingActive)
            {
                try
                {
                    var result = await udpClient.ReceiveAsync();

                    newReceivedMessage = Encoding.UTF8.GetString(result.Buffer);
                }
                catch { }
            }
        }

        async public void TrySendCommand(int F, int B, int T)
        {
            numberOfCommand++;
            string json = CreateJsonForRobot(F,B,T);

            await udpClient.SendAsync(Encoding.UTF8.GetBytes(json), json.Length,remoteEndPoint);

            newTranslatedMessage = json;
        }

        private string CreateJsonForRobot(int F, int B, int T)
        {
            var data = new
            {
                N = numberOfCommand,
                M = "0",
                F = F,
                B = B,
                T = T,
                L0 = "0",
                L1 = "0",
                L2 = "0",
                L3 = "0",
                L4 = "0",
                TEXT = " "
            };

            return JsonSerializer.Serialize(data)+"\n";
        }

        public void StopRecievingMessages()
        {
            isRecievingActive = false;
        }
    }
}
