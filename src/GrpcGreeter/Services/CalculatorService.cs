using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        private readonly ILogger<CalculatorService> _logger;
        public CalculatorService(ILogger<CalculatorService> logger)
        {
            _logger = logger;
        }

        public override Task<OperationReply> Addition(OperationRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OperationReply
            {
                Message = "Operation: " + request.Name,
                Result = request.NumberOne + request.NumberTwo 
            });
        }

        public override Task<OperationReply> Subtraction(OperationRequest request, ServerCallContext context)
        {
            return Task.FromResult(new OperationReply
            {
                Message = "Operation: " + request.Name,
                Result = request.NumberOne - request.NumberTwo 
            });
        }
        
    }
}
