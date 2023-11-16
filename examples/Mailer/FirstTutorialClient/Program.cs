using Grpc.Net.Client;
using GrpcService;

using var channel = GrpcChannel.ForAddress("http://localhost:3388");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest() {Name = "Greeter Client"});

Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
