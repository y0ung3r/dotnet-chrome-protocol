// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  /// <summary>The Browser domain defines methods and events for browser managing.</summary>
  public static partial class Browser
  {
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record BrowserContextIDType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record WindowIDType(
      int Value
    ) : ChromeProtocol.Core.PrimitiveType<int>(Value)
    {
    }
    /// <summary>The state of the browser window.</summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record WindowStateType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Browser window bounds information</summary>
    /// <param name="Left">The offset from the left edge of the screen to the window in pixels.</param>
    /// <param name="Top">The offset from the top edge of the screen to the window in pixels.</param>
    /// <param name="Width">The window width in pixels.</param>
    /// <param name="Height">The window height in pixels.</param>
    /// <param name="WindowState">The window state. Default to normal.</param>
    public record BoundsType(
      [property: System.Text.Json.Serialization.JsonPropertyName("left")]
      int? Left = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("top")]
      int? Top = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("width")]
      int? Width = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("height")]
      int? Height = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("windowState")]
      ChromeProtocol.Domains.Browser.WindowStateType? WindowState = default
    ) : ChromeProtocol.Core.IType
    {
    }
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record PermissionTypeType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record PermissionSettingType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>
    /// Definition of PermissionDescriptor defined in the Permissions API:<br/>
    /// https://w3c.github.io/permissions/#dom-permissiondescriptor.<br/>
    /// </summary>
    /// <param name="Name">
    /// Name of permission.<br/>
    /// See https://cs.chromium.org/chromium/src/third_party/blink/renderer/modules/permissions/permission_descriptor.idl for valid permission names.<br/>
    /// </param>
    /// <param name="Sysex">For &quot;midi&quot; permission, may also specify sysex control.</param>
    /// <param name="UserVisibleOnly">
    /// For &quot;push&quot; permission, may specify userVisibleOnly.<br/>
    /// Note that userVisibleOnly = true is the only currently supported type.<br/>
    /// </param>
    /// <param name="AllowWithoutSanitization">For &quot;clipboard&quot; permission, may specify allowWithoutSanitization.</param>
    /// <param name="PanTiltZoom">For &quot;camera&quot; permission, may specify panTiltZoom.</param>
    public record PermissionDescriptorType(
      [property: System.Text.Json.Serialization.JsonPropertyName("name")]
      string Name,
      [property: System.Text.Json.Serialization.JsonPropertyName("sysex")]
      bool? Sysex = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("userVisibleOnly")]
      bool? UserVisibleOnly = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("allowWithoutSanitization")]
      bool? AllowWithoutSanitization = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("panTiltZoom")]
      bool? PanTiltZoom = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Browser command ids used by executeBrowserCommand.</summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(ChromeProtocol.Core.PrimitiveTypeConverter))]
    public record BrowserCommandIdType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Chrome histogram bucket.</summary>
    /// <param name="Low">Minimum value (inclusive).</param>
    /// <param name="High">Maximum value (exclusive).</param>
    /// <param name="Count">Number of samples.</param>
    public record BucketType(
      [property: System.Text.Json.Serialization.JsonPropertyName("low")]
      int Low,
      [property: System.Text.Json.Serialization.JsonPropertyName("high")]
      int High,
      [property: System.Text.Json.Serialization.JsonPropertyName("count")]
      int Count
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Chrome histogram.</summary>
    /// <param name="Name">Name.</param>
    /// <param name="Sum">Sum of sample values.</param>
    /// <param name="Count">Total number of samples.</param>
    /// <param name="Buckets">Buckets.</param>
    public record HistogramType(
      [property: System.Text.Json.Serialization.JsonPropertyName("name")]
      string Name,
      [property: System.Text.Json.Serialization.JsonPropertyName("sum")]
      int Sum,
      [property: System.Text.Json.Serialization.JsonPropertyName("count")]
      int Count,
      [property: System.Text.Json.Serialization.JsonPropertyName("buckets")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Browser.BucketType> Buckets
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Fired when page is about to start a download.</summary>
    /// <param name="FrameId">Id of the frame that caused the download to begin.</param>
    /// <param name="Guid">Global unique identifier of the download.</param>
    /// <param name="Url">URL of the resource being downloaded.</param>
    /// <param name="SuggestedFilename">Suggested file name of the resource (the actual name of the file saved on disk may differ).</param>
    [ChromeProtocol.Core.MethodName("Browser.downloadWillBegin")]
    public record DownloadWillBegin(
      [property: System.Text.Json.Serialization.JsonPropertyName("frameId")]
      ChromeProtocol.Domains.Page.FrameIdType FrameId,
      [property: System.Text.Json.Serialization.JsonPropertyName("guid")]
      string Guid,
      [property: System.Text.Json.Serialization.JsonPropertyName("url")]
      string Url,
      [property: System.Text.Json.Serialization.JsonPropertyName("suggestedFilename")]
      string SuggestedFilename
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Fired when download makes progress. Last call has |done| == true.</summary>
    /// <param name="Guid">Global unique identifier of the download.</param>
    /// <param name="TotalBytes">Total expected bytes to download.</param>
    /// <param name="ReceivedBytes">Total bytes received.</param>
    /// <param name="State">Download status.</param>
    [ChromeProtocol.Core.MethodName("Browser.downloadProgress")]
    public record DownloadProgress(
      [property: System.Text.Json.Serialization.JsonPropertyName("guid")]
      string Guid,
      [property: System.Text.Json.Serialization.JsonPropertyName("totalBytes")]
      double TotalBytes,
      [property: System.Text.Json.Serialization.JsonPropertyName("receivedBytes")]
      double ReceivedBytes,
      [property: System.Text.Json.Serialization.JsonPropertyName("state")]
      string State
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Set permission settings for given origin.</summary>
    /// <param name="Permission">Descriptor of permission to override.</param>
    /// <param name="Setting">Setting of the permission.</param>
    /// <param name="Origin">Origin the permission applies to, all origins if not specified.</param>
    /// <param name="BrowserContextId">Context to override. When omitted, default browser context is used.</param>
    public static ChromeProtocol.Domains.Browser.SetPermissionRequest SetPermission(ChromeProtocol.Domains.Browser.PermissionDescriptorType Permission, ChromeProtocol.Domains.Browser.PermissionSettingType Setting, string? Origin = default, ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default)
    {
      return new ChromeProtocol.Domains.Browser.SetPermissionRequest(Permission, Setting, Origin, BrowserContextId);
    }
    /// <summary>Set permission settings for given origin.</summary>
    /// <param name="Permission">Descriptor of permission to override.</param>
    /// <param name="Setting">Setting of the permission.</param>
    /// <param name="Origin">Origin the permission applies to, all origins if not specified.</param>
    /// <param name="BrowserContextId">Context to override. When omitted, default browser context is used.</param>
    [ChromeProtocol.Core.MethodName("Browser.setPermission")]
    public record SetPermissionRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("permission")]
      ChromeProtocol.Domains.Browser.PermissionDescriptorType Permission,
      [property: System.Text.Json.Serialization.JsonPropertyName("setting")]
      ChromeProtocol.Domains.Browser.PermissionSettingType Setting,
      [property: System.Text.Json.Serialization.JsonPropertyName("origin")]
      string? Origin = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("browserContextId")]
      ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default
    ) : ChromeProtocol.Core.ICommand<SetPermissionRequestResult>
    {
    }
    public record SetPermissionRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Grant specific permissions to the given origin and reject all others.</summary>
    /// <param name="Origin">Origin the permission applies to, all origins if not specified.</param>
    /// <param name="BrowserContextId">BrowserContext to override permissions. When omitted, default browser context is used.</param>
    public static ChromeProtocol.Domains.Browser.GrantPermissionsRequest GrantPermissions(System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Browser.PermissionTypeType> Permissions, string? Origin = default, ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default)
    {
      return new ChromeProtocol.Domains.Browser.GrantPermissionsRequest(Permissions, Origin, BrowserContextId);
    }
    /// <summary>Grant specific permissions to the given origin and reject all others.</summary>
    /// <param name="Origin">Origin the permission applies to, all origins if not specified.</param>
    /// <param name="BrowserContextId">BrowserContext to override permissions. When omitted, default browser context is used.</param>
    [ChromeProtocol.Core.MethodName("Browser.grantPermissions")]
    public record GrantPermissionsRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("permissions")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Browser.PermissionTypeType> Permissions,
      [property: System.Text.Json.Serialization.JsonPropertyName("origin")]
      string? Origin = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("browserContextId")]
      ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default
    ) : ChromeProtocol.Core.ICommand<GrantPermissionsRequestResult>
    {
    }
    public record GrantPermissionsRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Reset all permission management for all origins.</summary>
    /// <param name="BrowserContextId">BrowserContext to reset permissions. When omitted, default browser context is used.</param>
    public static ChromeProtocol.Domains.Browser.ResetPermissionsRequest ResetPermissions(ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default)
    {
      return new ChromeProtocol.Domains.Browser.ResetPermissionsRequest(BrowserContextId);
    }
    /// <summary>Reset all permission management for all origins.</summary>
    /// <param name="BrowserContextId">BrowserContext to reset permissions. When omitted, default browser context is used.</param>
    [ChromeProtocol.Core.MethodName("Browser.resetPermissions")]
    public record ResetPermissionsRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("browserContextId")]
      ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default
    ) : ChromeProtocol.Core.ICommand<ResetPermissionsRequestResult>
    {
    }
    public record ResetPermissionsRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Set the behavior when downloading a file.</summary>
    /// <param name="Behavior">
    /// Whether to allow all or deny all download requests, or use default Chrome behavior if<br/>
    /// available (otherwise deny). |allowAndName| allows download and names files according to<br/>
    /// their download guids.<br/>
    /// </param>
    /// <param name="BrowserContextId">BrowserContext to set download behavior. When omitted, default browser context is used.</param>
    /// <param name="DownloadPath">
    /// The default path to save downloaded files to. This is required if behavior is set to &#39;allow&#39;<br/>
    /// or &#39;allowAndName&#39;.<br/>
    /// </param>
    /// <param name="EventsEnabled">Whether to emit download events (defaults to false).</param>
    public static ChromeProtocol.Domains.Browser.SetDownloadBehaviorRequest SetDownloadBehavior(string Behavior, ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default, string? DownloadPath = default, bool? EventsEnabled = default)
    {
      return new ChromeProtocol.Domains.Browser.SetDownloadBehaviorRequest(Behavior, BrowserContextId, DownloadPath, EventsEnabled);
    }
    /// <summary>Set the behavior when downloading a file.</summary>
    /// <param name="Behavior">
    /// Whether to allow all or deny all download requests, or use default Chrome behavior if<br/>
    /// available (otherwise deny). |allowAndName| allows download and names files according to<br/>
    /// their download guids.<br/>
    /// </param>
    /// <param name="BrowserContextId">BrowserContext to set download behavior. When omitted, default browser context is used.</param>
    /// <param name="DownloadPath">
    /// The default path to save downloaded files to. This is required if behavior is set to &#39;allow&#39;<br/>
    /// or &#39;allowAndName&#39;.<br/>
    /// </param>
    /// <param name="EventsEnabled">Whether to emit download events (defaults to false).</param>
    [ChromeProtocol.Core.MethodName("Browser.setDownloadBehavior")]
    public record SetDownloadBehaviorRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("behavior")]
      string Behavior,
      [property: System.Text.Json.Serialization.JsonPropertyName("browserContextId")]
      ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("downloadPath")]
      string? DownloadPath = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("eventsEnabled")]
      bool? EventsEnabled = default
    ) : ChromeProtocol.Core.ICommand<SetDownloadBehaviorRequestResult>
    {
    }
    public record SetDownloadBehaviorRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Cancel a download if in progress</summary>
    /// <param name="Guid">Global unique identifier of the download.</param>
    /// <param name="BrowserContextId">BrowserContext to perform the action in. When omitted, default browser context is used.</param>
    public static ChromeProtocol.Domains.Browser.CancelDownloadRequest CancelDownload(string Guid, ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default)
    {
      return new ChromeProtocol.Domains.Browser.CancelDownloadRequest(Guid, BrowserContextId);
    }
    /// <summary>Cancel a download if in progress</summary>
    /// <param name="Guid">Global unique identifier of the download.</param>
    /// <param name="BrowserContextId">BrowserContext to perform the action in. When omitted, default browser context is used.</param>
    [ChromeProtocol.Core.MethodName("Browser.cancelDownload")]
    public record CancelDownloadRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("guid")]
      string Guid,
      [property: System.Text.Json.Serialization.JsonPropertyName("browserContextId")]
      ChromeProtocol.Domains.Browser.BrowserContextIDType? BrowserContextId = default
    ) : ChromeProtocol.Core.ICommand<CancelDownloadRequestResult>
    {
    }
    public record CancelDownloadRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Close browser gracefully.</summary>
    public static ChromeProtocol.Domains.Browser.CloseRequest Close()
    {
      return new ChromeProtocol.Domains.Browser.CloseRequest();
    }
    /// <summary>Close browser gracefully.</summary>
    [ChromeProtocol.Core.MethodName("Browser.close")]
    public record CloseRequest() : ChromeProtocol.Core.ICommand<CloseRequestResult>
    {
    }
    public record CloseRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Crashes browser on the main thread.</summary>
    public static ChromeProtocol.Domains.Browser.CrashRequest Crash()
    {
      return new ChromeProtocol.Domains.Browser.CrashRequest();
    }
    /// <summary>Crashes browser on the main thread.</summary>
    [ChromeProtocol.Core.MethodName("Browser.crash")]
    public record CrashRequest() : ChromeProtocol.Core.ICommand<CrashRequestResult>
    {
    }
    public record CrashRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Crashes GPU process.</summary>
    public static ChromeProtocol.Domains.Browser.CrashGpuProcessRequest CrashGpuProcess()
    {
      return new ChromeProtocol.Domains.Browser.CrashGpuProcessRequest();
    }
    /// <summary>Crashes GPU process.</summary>
    [ChromeProtocol.Core.MethodName("Browser.crashGpuProcess")]
    public record CrashGpuProcessRequest() : ChromeProtocol.Core.ICommand<CrashGpuProcessRequestResult>
    {
    }
    public record CrashGpuProcessRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Returns version information.</summary>
    public static ChromeProtocol.Domains.Browser.GetVersionRequest GetVersion()
    {
      return new ChromeProtocol.Domains.Browser.GetVersionRequest();
    }
    /// <summary>Returns version information.</summary>
    [ChromeProtocol.Core.MethodName("Browser.getVersion")]
    public record GetVersionRequest() : ChromeProtocol.Core.ICommand<GetVersionRequestResult>
    {
    }
    /// <param name="ProtocolVersion">Protocol version.</param>
    /// <param name="Product">Product name.</param>
    /// <param name="Revision">Product revision.</param>
    /// <param name="UserAgent">User-Agent.</param>
    /// <param name="JsVersion">V8 version.</param>
    public record GetVersionRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
      string ProtocolVersion,
      [property: System.Text.Json.Serialization.JsonPropertyName("product")]
      string Product,
      [property: System.Text.Json.Serialization.JsonPropertyName("revision")]
      string Revision,
      [property: System.Text.Json.Serialization.JsonPropertyName("userAgent")]
      string UserAgent,
      [property: System.Text.Json.Serialization.JsonPropertyName("jsVersion")]
      string JsVersion
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Returns the command line switches for the browser process if, and only if<br/>
    /// --enable-automation is on the commandline.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Browser.GetBrowserCommandLineRequest GetBrowserCommandLine()
    {
      return new ChromeProtocol.Domains.Browser.GetBrowserCommandLineRequest();
    }
    /// <summary>
    /// Returns the command line switches for the browser process if, and only if<br/>
    /// --enable-automation is on the commandline.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Browser.getBrowserCommandLine")]
    public record GetBrowserCommandLineRequest() : ChromeProtocol.Core.ICommand<GetBrowserCommandLineRequestResult>
    {
    }
    /// <param name="Arguments">Commandline parameters</param>
    public record GetBrowserCommandLineRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("arguments")]
      System.Collections.Generic.IReadOnlyList<string> Arguments
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Get Chrome histograms.</summary>
    /// <param name="Query">
    /// Requested substring in name. Only histograms which have query as a<br/>
    /// substring in their name are extracted. An empty or absent query returns<br/>
    /// all histograms.<br/>
    /// </param>
    /// <param name="Delta">If true, retrieve delta since last delta call.</param>
    public static ChromeProtocol.Domains.Browser.GetHistogramsRequest GetHistograms(string? Query = default, bool? Delta = default)
    {
      return new ChromeProtocol.Domains.Browser.GetHistogramsRequest(Query, Delta);
    }
    /// <summary>Get Chrome histograms.</summary>
    /// <param name="Query">
    /// Requested substring in name. Only histograms which have query as a<br/>
    /// substring in their name are extracted. An empty or absent query returns<br/>
    /// all histograms.<br/>
    /// </param>
    /// <param name="Delta">If true, retrieve delta since last delta call.</param>
    [ChromeProtocol.Core.MethodName("Browser.getHistograms")]
    public record GetHistogramsRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("query")]
      string? Query = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("delta")]
      bool? Delta = default
    ) : ChromeProtocol.Core.ICommand<GetHistogramsRequestResult>
    {
    }
    /// <param name="Histograms">Histograms.</param>
    public record GetHistogramsRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("histograms")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Browser.HistogramType> Histograms
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Get a Chrome histogram by name.</summary>
    /// <param name="Name">Requested histogram name.</param>
    /// <param name="Delta">If true, retrieve delta since last delta call.</param>
    public static ChromeProtocol.Domains.Browser.GetHistogramRequest GetHistogram(string Name, bool? Delta = default)
    {
      return new ChromeProtocol.Domains.Browser.GetHistogramRequest(Name, Delta);
    }
    /// <summary>Get a Chrome histogram by name.</summary>
    /// <param name="Name">Requested histogram name.</param>
    /// <param name="Delta">If true, retrieve delta since last delta call.</param>
    [ChromeProtocol.Core.MethodName("Browser.getHistogram")]
    public record GetHistogramRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("name")]
      string Name,
      [property: System.Text.Json.Serialization.JsonPropertyName("delta")]
      bool? Delta = default
    ) : ChromeProtocol.Core.ICommand<GetHistogramRequestResult>
    {
    }
    /// <param name="Histogram">Histogram.</param>
    public record GetHistogramRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("histogram")]
      ChromeProtocol.Domains.Browser.HistogramType Histogram
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Get position and size of the browser window.</summary>
    /// <param name="WindowId">Browser window id.</param>
    public static ChromeProtocol.Domains.Browser.GetWindowBoundsRequest GetWindowBounds(ChromeProtocol.Domains.Browser.WindowIDType WindowId)
    {
      return new ChromeProtocol.Domains.Browser.GetWindowBoundsRequest(WindowId);
    }
    /// <summary>Get position and size of the browser window.</summary>
    /// <param name="WindowId">Browser window id.</param>
    [ChromeProtocol.Core.MethodName("Browser.getWindowBounds")]
    public record GetWindowBoundsRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("windowId")]
      ChromeProtocol.Domains.Browser.WindowIDType WindowId
    ) : ChromeProtocol.Core.ICommand<GetWindowBoundsRequestResult>
    {
    }
    /// <param name="Bounds">
    /// Bounds information of the window. When window state is &#39;minimized&#39;, the restored window<br/>
    /// position and size are returned.<br/>
    /// </param>
    public record GetWindowBoundsRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("bounds")]
      ChromeProtocol.Domains.Browser.BoundsType Bounds
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Get the browser window that contains the devtools target.</summary>
    /// <param name="TargetId">Devtools agent host id. If called as a part of the session, associated targetId is used.</param>
    public static ChromeProtocol.Domains.Browser.GetWindowForTargetRequest GetWindowForTarget(ChromeProtocol.Domains.Target.TargetIDType? TargetId = default)
    {
      return new ChromeProtocol.Domains.Browser.GetWindowForTargetRequest(TargetId);
    }
    /// <summary>Get the browser window that contains the devtools target.</summary>
    /// <param name="TargetId">Devtools agent host id. If called as a part of the session, associated targetId is used.</param>
    [ChromeProtocol.Core.MethodName("Browser.getWindowForTarget")]
    public record GetWindowForTargetRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("targetId")]
      ChromeProtocol.Domains.Target.TargetIDType? TargetId = default
    ) : ChromeProtocol.Core.ICommand<GetWindowForTargetRequestResult>
    {
    }
    /// <param name="WindowId">Browser window id.</param>
    /// <param name="Bounds">
    /// Bounds information of the window. When window state is &#39;minimized&#39;, the restored window<br/>
    /// position and size are returned.<br/>
    /// </param>
    public record GetWindowForTargetRequestResult(
      [property: System.Text.Json.Serialization.JsonPropertyName("windowId")]
      ChromeProtocol.Domains.Browser.WindowIDType WindowId,
      [property: System.Text.Json.Serialization.JsonPropertyName("bounds")]
      ChromeProtocol.Domains.Browser.BoundsType Bounds
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Set position and/or size of the browser window.</summary>
    /// <param name="WindowId">Browser window id.</param>
    /// <param name="Bounds">
    /// New window bounds. The &#39;minimized&#39;, &#39;maximized&#39; and &#39;fullscreen&#39; states cannot be combined<br/>
    /// with &#39;left&#39;, &#39;top&#39;, &#39;width&#39; or &#39;height&#39;. Leaves unspecified fields unchanged.<br/>
    /// </param>
    public static ChromeProtocol.Domains.Browser.SetWindowBoundsRequest SetWindowBounds(ChromeProtocol.Domains.Browser.WindowIDType WindowId, ChromeProtocol.Domains.Browser.BoundsType Bounds)
    {
      return new ChromeProtocol.Domains.Browser.SetWindowBoundsRequest(WindowId, Bounds);
    }
    /// <summary>Set position and/or size of the browser window.</summary>
    /// <param name="WindowId">Browser window id.</param>
    /// <param name="Bounds">
    /// New window bounds. The &#39;minimized&#39;, &#39;maximized&#39; and &#39;fullscreen&#39; states cannot be combined<br/>
    /// with &#39;left&#39;, &#39;top&#39;, &#39;width&#39; or &#39;height&#39;. Leaves unspecified fields unchanged.<br/>
    /// </param>
    [ChromeProtocol.Core.MethodName("Browser.setWindowBounds")]
    public record SetWindowBoundsRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("windowId")]
      ChromeProtocol.Domains.Browser.WindowIDType WindowId,
      [property: System.Text.Json.Serialization.JsonPropertyName("bounds")]
      ChromeProtocol.Domains.Browser.BoundsType Bounds
    ) : ChromeProtocol.Core.ICommand<SetWindowBoundsRequestResult>
    {
    }
    public record SetWindowBoundsRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Set dock tile details, platform-specific.</summary>
    /// <param name="Image">Png encoded image. (Encoded as a base64 string when passed over JSON)</param>
    public static ChromeProtocol.Domains.Browser.SetDockTileRequest SetDockTile(string? BadgeLabel = default, string? Image = default)
    {
      return new ChromeProtocol.Domains.Browser.SetDockTileRequest(BadgeLabel, Image);
    }
    /// <summary>Set dock tile details, platform-specific.</summary>
    /// <param name="Image">Png encoded image. (Encoded as a base64 string when passed over JSON)</param>
    [ChromeProtocol.Core.MethodName("Browser.setDockTile")]
    public record SetDockTileRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("badgeLabel")]
      string? BadgeLabel = default,
      [property: System.Text.Json.Serialization.JsonPropertyName("image")]
      string? Image = default
    ) : ChromeProtocol.Core.ICommand<SetDockTileRequestResult>
    {
    }
    public record SetDockTileRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Invoke custom browser commands used by telemetry.</summary>
    public static ChromeProtocol.Domains.Browser.ExecuteBrowserCommandRequest ExecuteBrowserCommand(ChromeProtocol.Domains.Browser.BrowserCommandIdType CommandId)
    {
      return new ChromeProtocol.Domains.Browser.ExecuteBrowserCommandRequest(CommandId);
    }
    /// <summary>Invoke custom browser commands used by telemetry.</summary>
    [ChromeProtocol.Core.MethodName("Browser.executeBrowserCommand")]
    public record ExecuteBrowserCommandRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("commandId")]
      ChromeProtocol.Domains.Browser.BrowserCommandIdType CommandId
    ) : ChromeProtocol.Core.ICommand<ExecuteBrowserCommandRequestResult>
    {
    }
    public record ExecuteBrowserCommandRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Allows a site to use privacy sandbox features that require enrollment<br/>
    /// without the site actually being enrolled. Only supported on page targets.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Browser.AddPrivacySandboxEnrollmentOverrideRequest AddPrivacySandboxEnrollmentOverride(string Url)
    {
      return new ChromeProtocol.Domains.Browser.AddPrivacySandboxEnrollmentOverrideRequest(Url);
    }
    /// <summary>
    /// Allows a site to use privacy sandbox features that require enrollment<br/>
    /// without the site actually being enrolled. Only supported on page targets.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Browser.addPrivacySandboxEnrollmentOverride")]
    public record AddPrivacySandboxEnrollmentOverrideRequest(
      [property: System.Text.Json.Serialization.JsonPropertyName("url")]
      string Url
    ) : ChromeProtocol.Core.ICommand<AddPrivacySandboxEnrollmentOverrideRequestResult>
    {
    }
    public record AddPrivacySandboxEnrollmentOverrideRequestResult() : ChromeProtocol.Core.IType
    {
    }
  }
}
