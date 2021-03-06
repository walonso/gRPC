// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/calculator-service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Calculator
  {
    static readonly string __ServiceName = "greet.Calculator";

    static readonly grpc::Marshaller<global::GrpcGreeter.OperationRequest> __Marshaller_greet_OperationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.OperationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.OperationReply> __Marshaller_greet_OperationReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.OperationReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply> __Method_Addition = new grpc::Method<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Addition",
        __Marshaller_greet_OperationRequest,
        __Marshaller_greet_OperationReply);

    static readonly grpc::Method<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply> __Method_Subtraction = new grpc::Method<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Subtraction",
        __Marshaller_greet_OperationRequest,
        __Marshaller_greet_OperationReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.CalculatorServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Calculator</summary>
    [grpc::BindServiceMethod(typeof(Calculator), "BindService")]
    public abstract partial class CalculatorBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.OperationReply> Addition(global::GrpcGreeter.OperationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.OperationReply> Subtraction(global::GrpcGreeter.OperationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalculatorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Addition, serviceImpl.Addition)
          .AddMethod(__Method_Subtraction, serviceImpl.Subtraction).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CalculatorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Addition, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply>(serviceImpl.Addition));
      serviceBinder.AddMethod(__Method_Subtraction, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.OperationRequest, global::GrpcGreeter.OperationReply>(serviceImpl.Subtraction));
    }

  }
}
#endregion
