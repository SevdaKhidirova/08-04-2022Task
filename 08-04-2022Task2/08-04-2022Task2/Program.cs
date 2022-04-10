using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _08_04_2022Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string context = httpClient.GetStringAsync(@"https://jsonplaceholder.typicode.com/posts").Result;
            //Console.WriteLine(context);

            List<Comment> ls = JsonConvert.DeserializeObject<List<Comment>>(context);
            foreach (Comment item in ls)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}

/*https://jsonplaceholder.typicode.com/posts linkindəki datani götürüb bu data-
 * dakı bütün postların title-larını console-a yazdıran console app yazın. */