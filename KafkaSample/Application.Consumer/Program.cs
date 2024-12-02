using Application.Services;
using System;

namespace Application
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("*** Consumer is run! :) ***\n\n");
            KafkaConsumer Consumer = new KafkaConsumer();

            Consumer.ReceiveMessage();
        }
    }
}
