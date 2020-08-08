// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/division-service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcGreeter {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Division
  {
    static readonly string __ServiceName = "greet.Division";

    static readonly grpc::Marshaller<global::GrpcGreeter.DivisionRequest> __Marshaller_greet_DivisionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.DivisionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcGreeter.DivisionReply> __Marshaller_greet_DivisionReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcGreeter.DivisionReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcGreeter.DivisionRequest, global::GrpcGreeter.DivisionReply> __Method_Division = new grpc::Method<global::GrpcGreeter.DivisionRequest, global::GrpcGreeter.DivisionReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Division",
        __Marshaller_greet_DivisionRequest,
        __Marshaller_greet_DivisionReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcGreeter.DivisionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Division</summary>
    [grpc::BindServiceMethod(typeof(Division), "BindService")]
    public abstract partial class DivisionBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcGreeter.DivisionReply> Division(global::GrpcGreeter.DivisionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DivisionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Division, serviceImpl.Division).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DivisionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Division, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcGreeter.DivisionRequest, global::GrpcGreeter.DivisionReply>(serviceImpl.Division));
    }

  }
}
#endregion