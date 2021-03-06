// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/multiplication-service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Multiplication
  {
    static readonly string __ServiceName = "greet.Multiplication";

    static readonly grpc::Marshaller<global::GrpcGreeter.MultiplicationRequest> __Marshaller_greet_MultiplicationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.MultiplicationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.MultiplicationReply> __Marshaller_greet_MultiplicationReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.MultiplicationReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.MultiplicationRequest, global::GrpcGreeter.MultiplicationReply> __Method_Multiplication = new grpc::Method<global::GrpcGreeter.MultiplicationRequest, global::GrpcGreeter.MultiplicationReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Multiplication",
        __Marshaller_greet_MultiplicationRequest,
        __Marshaller_greet_MultiplicationReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.MultiplicationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Multiplication</summary>
    [grpc::BindServiceMethod(typeof(Multiplication), "BindService")]
    public abstract partial class MultiplicationBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.MultiplicationReply> Multiplication(global::GrpcGreeter.MultiplicationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MultiplicationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Multiplication, serviceImpl.Multiplication).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MultiplicationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Multiplication, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.MultiplicationRequest, global::GrpcGreeter.MultiplicationReply>(serviceImpl.Multiplication));
    }

  }
}
#endregion
