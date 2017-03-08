using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;


namespace ConsoleApplication1
{
    class Szerver
    {


        public static int connectedClients = 0;
        private string pathLog = "@log.txt";

        private static void ProcessClientRequests(object argument)
        {
            TcpClient client = (TcpClient)argument;
            try
            {
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                while(!(s = reader.ReadLine()).Equals("Exit") || (s == null))
                {
                    Console.WriteLine("From clients -> " + s);
                    writer.WriteLine("From servers -> " + s);
                    writer.Flush(); 
                }
                reader.Close();
                writer.Close();
                client.Close();
                connectedClients--;
                Console.WriteLine("Closing client connection!");
                Console.WriteLine(connectedClients + "client(s)\n");

            }catch(IOException ioex)
            {
                Console.WriteLine(ioex.ToString());
            }
            finally
            {
                if(client != null)
                {
                    client.Close();
                }
            }
        }


        static void Main(string[] args)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8910);
                listener.Start();
                Console.WriteLine("A szerver elindult....");
                while(true)
                {
                    Console.WriteLine("Várakozás a kliensekre....");
                    TcpClient client = listener.AcceptTcpClient();
                    connectedClients++;
                    Console.WriteLine("Az új kliens kapcsolódása...");
                    Console.WriteLine(client.Client.LocalEndPoint.ToString());
                    Console.WriteLine(connectedClients + "client(s)\n");

                    Thread t = new Thread(ProcessClientRequests);
                    t.Start(client);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if(listener != null)
                {
                    listener.Stop();
                }
            }
        }

        public void clientsLog(string client)
        {
            try
            {
                FileStream fs = new FileStream(pathLog, FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(client + ";");
                sw.Close();
                fs.Close();

            }catch(Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }
    }
}
