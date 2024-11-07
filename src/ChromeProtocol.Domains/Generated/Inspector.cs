// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  public static partial class Inspector
  {
    /// <summary>Fired when remote debugging connection is about to be terminated. Contains detach reason.</summary>
    /// <param name="Reason">The reason why connection has been terminated.</param>
    [ChromeProtocol.Core.MethodName("Inspector.detached")]
    public record Detached(
      [property: System.Text.Json.Serialization.JsonPropertyName("reason")]
      string Reason
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Fired when debugging target has crashed</summary>
    [ChromeProtocol.Core.MethodName("Inspector.targetCrashed")]
    public record TargetCrashed() : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Fired when debugging target has reloaded after crash</summary>
    [ChromeProtocol.Core.MethodName("Inspector.targetReloadedAfterCrash")]
    public record TargetReloadedAfterCrash() : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Disables inspector domain notifications.</summary>
    public static ChromeProtocol.Domains.Inspector.DisableRequest Disable()
    {
      return new ChromeProtocol.Domains.Inspector.DisableRequest();
    }
    /// <summary>Disables inspector domain notifications.</summary>
    [ChromeProtocol.Core.MethodName("Inspector.disable")]
    public record DisableRequest() : ChromeProtocol.Core.ICommand<DisableRequestResult>
    {
    }
    public record DisableRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Enables inspector domain notifications.</summary>
    public static ChromeProtocol.Domains.Inspector.EnableRequest Enable()
    {
      return new ChromeProtocol.Domains.Inspector.EnableRequest();
    }
    /// <summary>Enables inspector domain notifications.</summary>
    [ChromeProtocol.Core.MethodName("Inspector.enable")]
    public record EnableRequest() : ChromeProtocol.Core.ICommand<EnableRequestResult>
    {
    }
    public record EnableRequestResult() : ChromeProtocol.Core.IType
    {
    }
  }
}
