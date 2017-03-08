using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace Kliens
{
    class Kliens
    {
        static void Main()
        {
            try
            {
                TcpClient client = new TcpClient("127.0.0.1", 8910);
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());
                String s = String.Empty;
                while(!s.Equals("Exit"))
                {
                    Console.WriteLine("Enter a string to send to the server: ");
                    s = Console.ReadLine();
                    Console.WriteLine();
                    writer.WriteLine(s);
                    writer.Flush();
                    String server_String = reader.ReadLine().ToString();
                    Console.WriteLine(server_String);

                }
                reader.Close();
                writer.Close();
                client.Close();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
  
}
}
