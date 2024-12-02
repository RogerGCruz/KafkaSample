using Application.Services;
using System;
using System.Threading.Tasks;

namespace Application.Productor
{
    public class Program
    {
        public static async Task Main()
        {
            Console.WriteLine("*** Producer! :) ***\n\n");
            await KafkaProductor.SendMessage();
        }
    }
}
