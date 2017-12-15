using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Timers;
using t = System.Threading;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace APITester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a string to send:");
            var line = Console.ReadLine();
            var client = new HttpClient() { BaseAddress = new Uri("http://localhost:59803/") };
            using (client)
            {
                try
                {
                    var resp = client.PostAsync("api/Projects", new StringContent(line, Encoding.UTF8, "application/json")).Result;
                }
                catch (Exception x)
                {
                    Console.WriteLine($"Error: {x.Message}");
                }
            }
        }
    }
}
