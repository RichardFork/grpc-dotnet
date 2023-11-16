using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Core.Logging;
using GrpcService;
using Microsoft.Extensions.Logging;
using static GrpcService.Greeter;

namespace FirstTutorial;
public class GreeterService : GreeterBase
{
    public GreeterService(MyLogger logger )
    {
        Debug.WriteLine("Injected Logger");
    }
    /// <summary>
    ///  HelloRequest를 받으면 호출이 된다.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply()
        {
            Message = "Hello" + request.Name
        });
    }
}
