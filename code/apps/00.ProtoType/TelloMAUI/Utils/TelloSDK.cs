using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TelloMAUI;


public class TelloSDK
{

    string telloIP = "192.168.10.1";
    int port = 8889;
    UdpClient udpClient;

    public TelloSDK()
    {
        this.udpClient = new UdpClient();
    }
    public void Connect()
    {
        this.udpClient.Connect(telloIP, port);
    }

    public void TakeOff()
    {
        Command("takeoff");
    }
    public void Land()
    {
        Command("land");
    }

    public void FlyCMD(string cmd)
    {
        Command(cmd);
    }

    public void Close()
    {
        this.udpClient.Close();
    }

    public void Dispose()
    {
        this.udpClient.Dispose();
    }

    public void Command(string cmd)
    {

        Byte[] sendCmdBytes = null;

        sendCmdBytes = Encoding.UTF8.GetBytes(cmd);

        //this.udpClient.Send(sendCmdBytes, sendCmdBytes.Length);


        if (cmd != "command" && cmd != "land" && cmd != "streamon" && cmd != "takeoff")
        {
            var start = DateTime.Now;

            bool status = true;

            while (status)
            {
                var current = DateTime.Now;

                if ((current - start).Seconds < 5)
                {

                    status = false;
                    Console.WriteLine("please wait 5 seconds");
                }
                else
                {
                    this.udpClient.Send(sendCmdBytes, sendCmdBytes.Length);
                    status = false;
                }

            }
        }
        else
        {
            this.udpClient.Send(sendCmdBytes, sendCmdBytes.Length);
        }
    }
}

