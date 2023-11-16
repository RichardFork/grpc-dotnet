using FirstTutorial;
using Grpc.Core;
using GrpcService;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<MyLogger>();
serviceCollection.AddSingleton<GreeterService>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var server = new Grpc.Core.Server()
{
    Services =
    {
        Greeter.BindService(serviceProvider.GetService<GreeterService>()),
    },
    Ports = { new ServerPort("localhost", 3388, ServerCredentials.Insecure)}
};
var ports = server.Ports;
server.Start();

Console.WriteLine("gRPC server listening on port 3388");
Console.WriteLine("Press any key to stop the server...");
Console.ReadKey();

server.ShutdownAsync().Wait();
