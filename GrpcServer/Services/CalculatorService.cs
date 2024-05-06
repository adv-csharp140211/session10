using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services;
public class CalculatorService : Calculator.CalculatorBase
{
    private readonly ILogger<GreeterService> _logger;
    public CalculatorService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<CalculatorReply> Add(CalculatorRequest request, ServerCallContext context)
    {
        var response = new CalculatorReply { Result = request.A + request.B };
        return Task.FromResult(response);
    }

    public override Task<CalculatorReply> Sub(CalculatorRequest request, ServerCallContext context)
    {
        var response = new CalculatorReply { Result = request.A - request.B };
        return Task.FromResult(response);
    }

    public override Task<CalculatorReply> Mul(CalculatorRequest request, ServerCallContext context)
    {
        var response = new CalculatorReply { Result = request.A * request.B };
        return Task.FromResult(response);
    }

    public override Task<CalculatorReply> Div(CalculatorRequest request, ServerCallContext context)
    {
        var response = new CalculatorReply { Result = request.A / request.B };
        return Task.FromResult(response);
    }

}
