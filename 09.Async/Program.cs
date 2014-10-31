using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
//using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.Async
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = SomeTask();

            Console.WriteLine("main");

            Console.WriteLine(task.Result);
        }



        static async Task<string> SomeTask()
        {
            var httpClient = new HttpClient();

            var result = await httpClient.GetAsync(
                "http://");

            var content = await result.Content.ReadAsStringAsync();

            return content;
        }
    }
}
