using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Hi!", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAl","MessageText":"Hi!","TimeStamp":"2021-07-16T08:59:18.1836244Z"}
            //RusAl < 7 / 16 / 2021 8:59:18 AM >: Hi!

            //Console.WriteLine("Начало проекта!");
            //Console.WriteLine(msg.ToString());
        }
    }
}
