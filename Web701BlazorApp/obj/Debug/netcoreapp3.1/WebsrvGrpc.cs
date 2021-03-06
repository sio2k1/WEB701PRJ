// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: websrv.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace WEB701GRPC.Protos {
  /// <summary>
  /// service definition.
  /// </summary>
  public static partial class Web701
  {
    static readonly string __ServiceName = "greet.Web701";

    static readonly grpc::Marshaller<global::WEB701GRPC.Protos.GetArticleListRequest> __Marshaller_greet_GetArticleListRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WEB701GRPC.Protos.GetArticleListRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::WEB701GRPC.Protos.ArticleListReply> __Marshaller_greet_ArticleListReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::WEB701GRPC.Protos.ArticleListReply.Parser.ParseFrom);

    static readonly grpc::Method<global::WEB701GRPC.Protos.GetArticleListRequest, global::WEB701GRPC.Protos.ArticleListReply> __Method_GetArticleList = new grpc::Method<global::WEB701GRPC.Protos.GetArticleListRequest, global::WEB701GRPC.Protos.ArticleListReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetArticleList",
        __Marshaller_greet_GetArticleListRequest,
        __Marshaller_greet_ArticleListReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::WEB701GRPC.Protos.WebsrvReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Web701</summary>
    public partial class Web701Client : grpc::ClientBase<Web701Client>
    {
      /// <summary>Creates a new client for Web701</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public Web701Client(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Web701 that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public Web701Client(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected Web701Client() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected Web701Client(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::WEB701GRPC.Protos.ArticleListReply GetArticleList(global::WEB701GRPC.Protos.GetArticleListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticleList(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::WEB701GRPC.Protos.ArticleListReply GetArticleList(global::WEB701GRPC.Protos.GetArticleListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetArticleList, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::WEB701GRPC.Protos.ArticleListReply> GetArticleListAsync(global::WEB701GRPC.Protos.GetArticleListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetArticleListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::WEB701GRPC.Protos.ArticleListReply> GetArticleListAsync(global::WEB701GRPC.Protos.GetArticleListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetArticleList, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override Web701Client NewInstance(ClientBaseConfiguration configuration)
      {
        return new Web701Client(configuration);
      }
    }

  }
}
#endregion
