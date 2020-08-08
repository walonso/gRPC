using System;
using System.Net.Http;
using System.Threading.Tasks;
using GrpcGreeter;
using Grpc.Net.Client;
using Grpc.Core;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            bool executeInParallel=false;

            if(executeInParallel){
                Task hello= Hello(channel);
                Task calculator= Calculator(channel);
                Task streaming= Streaming(channel);
                await Task.WhenAll(hello, calculator, streaming);
            } else {
                await Hello(channel);
               await Calculator(channel);
               await Streaming(channel);
            }
           
            Console.WriteLine("-----------------------------");            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static async Task Hello(GrpcChannel channel){
            Console.WriteLine("----- Method Hello ------------");
             var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "Hello World!" });
            Console.WriteLine("Hello: " + reply.Message);         
        }

        static async Task Calculator(GrpcChannel channel){
            Console.WriteLine("----- Method Calculator ------------");
            var client =  new Calculator.CalculatorClient(channel);
            var operationHeader = new OperationRequest { Name = "Addition", NumberOne=1, NumberTwo=2 };
            var reply = await client.AdditionAsync(operationHeader);

            Console.WriteLine("Message: " + reply.Message);
            Console.WriteLine($"Result: {operationHeader.NumberOne} + {operationHeader.NumberTwo} = " + reply.Result);            
        }

        static async Task Streaming(GrpcChannel channel){
            Console.WriteLine("----- Method Streaming ------------");
            var client =  new Streaming.StreamingClient(channel);
            var streamHeader = new StreamRequest { Name="video 1" };
            using var reply = client.Progress(streamHeader);

            while(await reply.ResponseStream.MoveNext())
            {
                var status = reply.ResponseStream.Current.Status;
                Console.WriteLine("Status: " + status);
            }                   
        }
    }
}
