// <auto-generated />
#nullable enable

namespace Protocol.Generated
{
  public static partial class DotnetRuntime
  {
    /// <summary>
    /// An alias for different version of Runtime.callFunctionOn used in Mono proxy.<br/>
    /// Don&#39;t use directly, send it as Runtime.callFunctionOn command.<br/>
    /// </summary>
    /// <param name="ObjectId">TBD</param>
    /// <param name="TypeName">TBD</param>
    /// <param name="MethodName">TBD</param>
    public static Protocol.Generated.DotnetRuntime.CallFunctionOnRequest CallFunctionOn(string ObjectId, string TypeName, string MethodName)
    {
      return new Protocol.Generated.DotnetRuntime.CallFunctionOnRequest(ObjectId, TypeName, MethodName);
    }
    /// <summary>
    /// An alias for different version of Runtime.callFunctionOn used in Mono proxy.<br/>
    /// Don&#39;t use directly, send it as Runtime.callFunctionOn command.<br/>
    /// </summary>
    /// <param name="ObjectId">TBD</param>
    /// <param name="TypeName">TBD</param>
    /// <param name="MethodName">TBD</param>
    [ChromeProtocol.Core.MethodName("DotnetRuntime.callFunctionOn")]
    public record CallFunctionOnRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("objectId")]
      string ObjectId,
      [property: System.Text.Json.Serialization.JsonPropertyName("typeName")]
      string TypeName,
      [property: System.Text.Json.Serialization.JsonPropertyName("methodName")]
      string MethodName
    ) : ChromeProtocol.Core.ICommand<CallFunctionOnRequestResult>
    {
    }
    /// <param name="Result">TBD</param>
    public record CallFunctionOnRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("result")]
      System.Text.Json.Nodes.JsonObject Result
    ) : ChromeProtocol.Core.IType
    {
    }
  }
}
