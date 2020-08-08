using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter
{
    public class StreamingService : Streaming.StreamingBase
    {
        private readonly ILogger<StreamingService> _logger;
        public StreamingService(ILogger<StreamingService> logger)
        {
            _logger = logger;
        }

        public override async Task Progress(StreamRequest request, IServerStreamWriter<StreamReply> replyStream, ServerCallContext context)
        {
            await replyStream.WriteAsync(
                new StreamReply{Status="Init"}
            );
            await Task.Delay(500);

            await replyStream.WriteAsync(
                new StreamReply{Status="In progress"}
            );
            await Task.Delay(500);
            
            await replyStream.WriteAsync(
                new StreamReply{Status="Finish"}
            );
        }
    }
}
