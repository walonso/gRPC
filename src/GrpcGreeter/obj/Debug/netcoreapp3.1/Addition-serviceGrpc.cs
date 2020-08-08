// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/addition-service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Addition
  {
    static readonly string __ServiceName = "greet.Addition";

    static readonly grpc::Marshaller<global::GrpcGreeter.AdditionRequest> __Marshaller_greet_AdditionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.AdditionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.AdditionReply> __Marshaller_greet_AdditionReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.AdditionReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.AdditionRequest, global::GrpcGreeter.AdditionReply> __Method_Operation = new grpc::Method<global::GrpcGreeter.AdditionRequest, global::GrpcGreeter.AdditionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Operation",
        __Marshaller_greet_AdditionRequest,
        __Marshaller_greet_AdditionReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.AdditionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Addition</summary>
    [grpc::BindServiceMethod(typeof(Addition), "BindService")]
    public abstract partial class AdditionBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.AdditionReply> Operation(global::GrpcGreeter.AdditionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdditionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Operation, serviceImpl.Operation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdditionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Operation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.AdditionRequest, global::GrpcGreeter.AdditionReply>(serviceImpl.Operation));
    }

  }
}
#endregion