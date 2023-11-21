// <auto-generated />
#nullable enable

namespace ChromeProtocol.Domains
{
  public static partial class Profiler
  {
    /// <summary>Profile node. Holds callsite information, execution statistics and child nodes.</summary>
    /// <param name="Id">Unique id of the node.</param>
    /// <param name="CallFrame">Function location.</param>
    /// <param name="HitCount">Number of samples where this node was on top of the call stack.</param>
    /// <param name="Children">Child node ids.</param>
    /// <param name="DeoptReason">
    /// The reason of being not optimized. The function may be deoptimized or marked as don&#39;t<br/>
    /// optimize.<br/>
    /// </param>
    /// <param name="PositionTicks">An array of source position ticks.</param>
    public record ProfileNodeType(
      [property: Newtonsoft.Json.JsonProperty("id")]
      int Id,
      [property: Newtonsoft.Json.JsonProperty("callFrame")]
      ChromeProtocol.Domains.Runtime.CallFrameType CallFrame,
      [property: Newtonsoft.Json.JsonProperty("hitCount")]
      int? HitCount = default,
      [property: Newtonsoft.Json.JsonProperty("children")]
      System.Collections.Generic.IReadOnlyList<int>? Children = default,
      [property: Newtonsoft.Json.JsonProperty("deoptReason")]
      string? DeoptReason = default,
      [property: Newtonsoft.Json.JsonProperty("positionTicks")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.PositionTickInfoType>? PositionTicks = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Profile.</summary>
    /// <param name="Nodes">The list of profile nodes. First item is the root node.</param>
    /// <param name="StartTime">Profiling start timestamp in microseconds.</param>
    /// <param name="EndTime">Profiling end timestamp in microseconds.</param>
    /// <param name="Samples">Ids of samples top nodes.</param>
    /// <param name="TimeDeltas">
    /// Time intervals between adjacent samples in microseconds. The first delta is relative to the<br/>
    /// profile startTime.<br/>
    /// </param>
    public record ProfileType(
      [property: Newtonsoft.Json.JsonProperty("nodes")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.ProfileNodeType> Nodes,
      [property: Newtonsoft.Json.JsonProperty("startTime")]
      double StartTime,
      [property: Newtonsoft.Json.JsonProperty("endTime")]
      double EndTime,
      [property: Newtonsoft.Json.JsonProperty("samples")]
      System.Collections.Generic.IReadOnlyList<int>? Samples = default,
      [property: Newtonsoft.Json.JsonProperty("timeDeltas")]
      System.Collections.Generic.IReadOnlyList<int>? TimeDeltas = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Specifies a number of samples attributed to a certain source position.</summary>
    /// <param name="Line">Source line number (1-based).</param>
    /// <param name="Ticks">Number of samples attributed to the source line.</param>
    public record PositionTickInfoType(
      [property: Newtonsoft.Json.JsonProperty("line")]
      int Line,
      [property: Newtonsoft.Json.JsonProperty("ticks")]
      int Ticks
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Coverage data for a source range.</summary>
    /// <param name="StartOffset">JavaScript script source offset for the range start.</param>
    /// <param name="EndOffset">JavaScript script source offset for the range end.</param>
    /// <param name="Count">Collected execution count of the source range.</param>
    public record CoverageRangeType(
      [property: Newtonsoft.Json.JsonProperty("startOffset")]
      int StartOffset,
      [property: Newtonsoft.Json.JsonProperty("endOffset")]
      int EndOffset,
      [property: Newtonsoft.Json.JsonProperty("count")]
      int Count
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Coverage data for a JavaScript function.</summary>
    /// <param name="FunctionName">JavaScript function name.</param>
    /// <param name="Ranges">Source ranges inside the function with coverage data.</param>
    /// <param name="IsBlockCoverage">Whether coverage data for this function has block granularity.</param>
    public record FunctionCoverageType(
      [property: Newtonsoft.Json.JsonProperty("functionName")]
      string FunctionName,
      [property: Newtonsoft.Json.JsonProperty("ranges")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.CoverageRangeType> Ranges,
      [property: Newtonsoft.Json.JsonProperty("isBlockCoverage")]
      bool IsBlockCoverage
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Coverage data for a JavaScript script.</summary>
    /// <param name="ScriptId">JavaScript script id.</param>
    /// <param name="Url">JavaScript script name or url.</param>
    /// <param name="Functions">Functions contained in the script that has coverage data.</param>
    public record ScriptCoverageType(
      [property: Newtonsoft.Json.JsonProperty("scriptId")]
      ChromeProtocol.Domains.Runtime.ScriptIdType ScriptId,
      [property: Newtonsoft.Json.JsonProperty("url")]
      string Url,
      [property: Newtonsoft.Json.JsonProperty("functions")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.FunctionCoverageType> Functions
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <param name="Location">Location of console.profileEnd().</param>
    /// <param name="Title">Profile title passed as an argument to console.profile().</param>
    [ChromeProtocol.Core.MethodName("Profiler.consoleProfileFinished")]
    public record ConsoleProfileFinished(
      [property: Newtonsoft.Json.JsonProperty("id")]
      string Id,
      [property: Newtonsoft.Json.JsonProperty("location")]
      ChromeProtocol.Domains.Debugger.LocationType Location,
      [property: Newtonsoft.Json.JsonProperty("profile")]
      ChromeProtocol.Domains.Profiler.ProfileType Profile,
      [property: Newtonsoft.Json.JsonProperty("title")]
      string? Title = default
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>Sent when new profile recording is started using console.profile() call.</summary>
    /// <param name="Location">Location of console.profile().</param>
    /// <param name="Title">Profile title passed as an argument to console.profile().</param>
    [ChromeProtocol.Core.MethodName("Profiler.consoleProfileStarted")]
    public record ConsoleProfileStarted(
      [property: Newtonsoft.Json.JsonProperty("id")]
      string Id,
      [property: Newtonsoft.Json.JsonProperty("location")]
      ChromeProtocol.Domains.Debugger.LocationType Location,
      [property: Newtonsoft.Json.JsonProperty("title")]
      string? Title = default
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <summary>
    /// Reports coverage delta since the last poll (either from an event like this, or from<br/>
    /// `takePreciseCoverage` for the current isolate. May only be sent if precise code<br/>
    /// coverage has been started. This event can be trigged by the embedder to, for example,<br/>
    /// trigger collection of coverage data immediately at a certain point in time.<br/>
    /// </summary>
    /// <param name="Timestamp">Monotonically increasing time (in seconds) when the coverage update was taken in the backend.</param>
    /// <param name="Occasion">Identifier for distinguishing coverage events.</param>
    /// <param name="Result">Coverage data for the current isolate.</param>
    [ChromeProtocol.Core.MethodName("Profiler.preciseCoverageDeltaUpdate")]
    public record PreciseCoverageDeltaUpdate(
      [property: Newtonsoft.Json.JsonProperty("timestamp")]
      double Timestamp,
      [property: Newtonsoft.Json.JsonProperty("occasion")]
      string Occasion,
      [property: Newtonsoft.Json.JsonProperty("result")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.ScriptCoverageType> Result
    ) : ChromeProtocol.Core.IEvent
    {
    }
    public static ChromeProtocol.Domains.Profiler.DisableRequest Disable()    
    {
      return new ChromeProtocol.Domains.Profiler.DisableRequest();
    }
    [ChromeProtocol.Core.MethodName("Profiler.disable")]
    public record DisableRequest() : ChromeProtocol.Core.ICommand<DisableRequestResult>
    {
    }
    public record DisableRequestResult() : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.Profiler.EnableRequest Enable()    
    {
      return new ChromeProtocol.Domains.Profiler.EnableRequest();
    }
    [ChromeProtocol.Core.MethodName("Profiler.enable")]
    public record EnableRequest() : ChromeProtocol.Core.ICommand<EnableRequestResult>
    {
    }
    public record EnableRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Collect coverage data for the current isolate. The coverage data may be incomplete due to<br/>
    /// garbage collection.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Profiler.GetBestEffortCoverageRequest GetBestEffortCoverage()    
    {
      return new ChromeProtocol.Domains.Profiler.GetBestEffortCoverageRequest();
    }
    /// <summary>
    /// Collect coverage data for the current isolate. The coverage data may be incomplete due to<br/>
    /// garbage collection.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Profiler.getBestEffortCoverage")]
    public record GetBestEffortCoverageRequest() : ChromeProtocol.Core.ICommand<GetBestEffortCoverageRequestResult>
    {
    }
    /// <param name="Result">Coverage data for the current isolate.</param>
    public record GetBestEffortCoverageRequestResult(
      [property: Newtonsoft.Json.JsonProperty("result")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.ScriptCoverageType> Result
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.</summary>
    /// <param name="Interval">New sampling interval in microseconds.</param>
    public static ChromeProtocol.Domains.Profiler.SetSamplingIntervalRequest SetSamplingInterval(int Interval)    
    {
      return new ChromeProtocol.Domains.Profiler.SetSamplingIntervalRequest(Interval);
    }
    /// <summary>Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.</summary>
    /// <param name="Interval">New sampling interval in microseconds.</param>
    [ChromeProtocol.Core.MethodName("Profiler.setSamplingInterval")]
    public record SetSamplingIntervalRequest(
      [property: Newtonsoft.Json.JsonProperty("interval")]
      int Interval
    ) : ChromeProtocol.Core.ICommand<SetSamplingIntervalRequestResult>
    {
    }
    public record SetSamplingIntervalRequestResult() : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.Profiler.StartRequest Start()    
    {
      return new ChromeProtocol.Domains.Profiler.StartRequest();
    }
    [ChromeProtocol.Core.MethodName("Profiler.start")]
    public record StartRequest() : ChromeProtocol.Core.ICommand<StartRequestResult>
    {
    }
    public record StartRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code<br/>
    /// coverage may be incomplete. Enabling prevents running optimized code and resets execution<br/>
    /// counters.<br/>
    /// </summary>
    /// <param name="CallCount">Collect accurate call counts beyond simple &#39;covered&#39; or &#39;not covered&#39;.</param>
    /// <param name="Detailed">Collect block-based coverage.</param>
    /// <param name="AllowTriggeredUpdates">Allow the backend to send updates on its own initiative</param>
    public static ChromeProtocol.Domains.Profiler.StartPreciseCoverageRequest StartPreciseCoverage(bool? CallCount = default, bool? Detailed = default, bool? AllowTriggeredUpdates = default)    
    {
      return new ChromeProtocol.Domains.Profiler.StartPreciseCoverageRequest(CallCount, Detailed, AllowTriggeredUpdates);
    }
    /// <summary>
    /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code<br/>
    /// coverage may be incomplete. Enabling prevents running optimized code and resets execution<br/>
    /// counters.<br/>
    /// </summary>
    /// <param name="CallCount">Collect accurate call counts beyond simple &#39;covered&#39; or &#39;not covered&#39;.</param>
    /// <param name="Detailed">Collect block-based coverage.</param>
    /// <param name="AllowTriggeredUpdates">Allow the backend to send updates on its own initiative</param>
    [ChromeProtocol.Core.MethodName("Profiler.startPreciseCoverage")]
    public record StartPreciseCoverageRequest(
      [property: Newtonsoft.Json.JsonProperty("callCount")]
      bool? CallCount = default,
      [property: Newtonsoft.Json.JsonProperty("detailed")]
      bool? Detailed = default,
      [property: Newtonsoft.Json.JsonProperty("allowTriggeredUpdates")]
      bool? AllowTriggeredUpdates = default
    ) : ChromeProtocol.Core.ICommand<StartPreciseCoverageRequestResult>
    {
    }
    /// <param name="Timestamp">Monotonically increasing time (in seconds) when the coverage update was taken in the backend.</param>
    public record StartPreciseCoverageRequestResult(
      [property: Newtonsoft.Json.JsonProperty("timestamp")]
      double Timestamp
    ) : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.Profiler.StopRequest Stop()    
    {
      return new ChromeProtocol.Domains.Profiler.StopRequest();
    }
    [ChromeProtocol.Core.MethodName("Profiler.stop")]
    public record StopRequest() : ChromeProtocol.Core.ICommand<StopRequestResult>
    {
    }
    /// <param name="Profile">Recorded profile.</param>
    public record StopRequestResult(
      [property: Newtonsoft.Json.JsonProperty("profile")]
      ChromeProtocol.Domains.Profiler.ProfileType Profile
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows<br/>
    /// executing optimized code.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Profiler.StopPreciseCoverageRequest StopPreciseCoverage()    
    {
      return new ChromeProtocol.Domains.Profiler.StopPreciseCoverageRequest();
    }
    /// <summary>
    /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows<br/>
    /// executing optimized code.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Profiler.stopPreciseCoverage")]
    public record StopPreciseCoverageRequest() : ChromeProtocol.Core.ICommand<StopPreciseCoverageRequestResult>
    {
    }
    public record StopPreciseCoverageRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Collect coverage data for the current isolate, and resets execution counters. Precise code<br/>
    /// coverage needs to have started.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.Profiler.TakePreciseCoverageRequest TakePreciseCoverage()    
    {
      return new ChromeProtocol.Domains.Profiler.TakePreciseCoverageRequest();
    }
    /// <summary>
    /// Collect coverage data for the current isolate, and resets execution counters. Precise code<br/>
    /// coverage needs to have started.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("Profiler.takePreciseCoverage")]
    public record TakePreciseCoverageRequest() : ChromeProtocol.Core.ICommand<TakePreciseCoverageRequestResult>
    {
    }
    /// <param name="Result">Coverage data for the current isolate.</param>
    /// <param name="Timestamp">Monotonically increasing time (in seconds) when the coverage update was taken in the backend.</param>
    public record TakePreciseCoverageRequestResult(
      [property: Newtonsoft.Json.JsonProperty("result")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.Profiler.ScriptCoverageType> Result,
      [property: Newtonsoft.Json.JsonProperty("timestamp")]
      double Timestamp
    ) : ChromeProtocol.Core.IType
    {
    }
  }
}