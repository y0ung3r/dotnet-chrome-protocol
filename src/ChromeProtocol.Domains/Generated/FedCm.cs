// <auto-generated />
#nullable enable

using ChromeProtocol.Core;

namespace ChromeProtocol.Domains
{
  /// <summary>This domain allows interacting with the FedCM dialog.</summary>
  public static partial class FedCm
  {
    /// <summary>
    /// Whether this is a sign-up or sign-in action for this account, i.e.<br/>
    /// whether this account has ever been used to sign in to this RP before.<br/>
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(PrimitiveTypeConverter))]
    public record LoginStateType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Whether the dialog shown is an account chooser or an auto re-authentication dialog.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(PrimitiveTypeConverter))]
    public record DialogTypeType(
      string Value
    ) : ChromeProtocol.Core.PrimitiveType<string>(Value)
    {
    }
    /// <summary>Corresponds to IdentityRequestAccount</summary>
    /// <param name="TermsOfServiceUrl">These two are only set if the loginState is signUp</param>
    public record AccountType(
      [property: Newtonsoft.Json.JsonProperty("accountId")]
      string AccountId,
      [property: Newtonsoft.Json.JsonProperty("email")]
      string Email,
      [property: Newtonsoft.Json.JsonProperty("name")]
      string Name,
      [property: Newtonsoft.Json.JsonProperty("givenName")]
      string GivenName,
      [property: Newtonsoft.Json.JsonProperty("pictureUrl")]
      string PictureUrl,
      [property: Newtonsoft.Json.JsonProperty("idpConfigUrl")]
      string IdpConfigUrl,
      [property: Newtonsoft.Json.JsonProperty("idpLoginUrl")]
      string IdpLoginUrl,
      [property: Newtonsoft.Json.JsonProperty("loginState")]
      ChromeProtocol.Domains.FedCm.LoginStateType LoginState,
      [property: Newtonsoft.Json.JsonProperty("termsOfServiceUrl")]
      string? TermsOfServiceUrl = default,
      [property: Newtonsoft.Json.JsonProperty("privacyPolicyUrl")]
      string? PrivacyPolicyUrl = default
    ) : ChromeProtocol.Core.IType
    {
    }
    /// <param name="Title">
    /// These exist primarily so that the caller can verify the<br/>
    /// RP context was used appropriately.<br/>
    /// </param>
    [ChromeProtocol.Core.MethodName("FedCm.dialogShown")]
    public record DialogShown(
      [property: Newtonsoft.Json.JsonProperty("dialogId")]
      string DialogId,
      [property: Newtonsoft.Json.JsonProperty("dialogType")]
      ChromeProtocol.Domains.FedCm.DialogTypeType DialogType,
      [property: Newtonsoft.Json.JsonProperty("accounts")]
      System.Collections.Generic.IReadOnlyList<ChromeProtocol.Domains.FedCm.AccountType> Accounts,
      [property: Newtonsoft.Json.JsonProperty("title")]
      string Title,
      [property: Newtonsoft.Json.JsonProperty("subtitle")]
      string? Subtitle = default
    ) : ChromeProtocol.Core.IEvent
    {
    }
    /// <param name="DisableRejectionDelay">
    /// Allows callers to disable the promise rejection delay that would<br/>
    /// normally happen, if this is unimportant to what&#39;s being tested.<br/>
    /// (step 4 of https://fedidcg.github.io/FedCM/#browser-api-rp-sign-in)<br/>
    /// </param>
    public static ChromeProtocol.Domains.FedCm.EnableRequest Enable(bool? DisableRejectionDelay = default)    
    {
      return new ChromeProtocol.Domains.FedCm.EnableRequest(DisableRejectionDelay);
    }
    /// <param name="DisableRejectionDelay">
    /// Allows callers to disable the promise rejection delay that would<br/>
    /// normally happen, if this is unimportant to what&#39;s being tested.<br/>
    /// (step 4 of https://fedidcg.github.io/FedCM/#browser-api-rp-sign-in)<br/>
    /// </param>
    [ChromeProtocol.Core.MethodName("FedCm.enable")]
    public record EnableRequest(
      [property: Newtonsoft.Json.JsonProperty("disableRejectionDelay")]
      bool? DisableRejectionDelay = default
    ) : ChromeProtocol.Core.ICommand<EnableRequestResult>
    {
    }
    public record EnableRequestResult() : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.FedCm.DisableRequest Disable()    
    {
      return new ChromeProtocol.Domains.FedCm.DisableRequest();
    }
    [ChromeProtocol.Core.MethodName("FedCm.disable")]
    public record DisableRequest() : ChromeProtocol.Core.ICommand<DisableRequestResult>
    {
    }
    public record DisableRequestResult() : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.FedCm.SelectAccountRequest SelectAccount(string DialogId, int AccountIndex)    
    {
      return new ChromeProtocol.Domains.FedCm.SelectAccountRequest(DialogId, AccountIndex);
    }
    [ChromeProtocol.Core.MethodName("FedCm.selectAccount")]
    public record SelectAccountRequest(
      [property: Newtonsoft.Json.JsonProperty("dialogId")]
      string DialogId,
      [property: Newtonsoft.Json.JsonProperty("accountIndex")]
      int AccountIndex
    ) : ChromeProtocol.Core.ICommand<SelectAccountRequestResult>
    {
    }
    public record SelectAccountRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Only valid if the dialog type is ConfirmIdpLogin. Acts as if the user had<br/>
    /// clicked the continue button.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.FedCm.ConfirmIdpLoginRequest ConfirmIdpLogin(string DialogId)    
    {
      return new ChromeProtocol.Domains.FedCm.ConfirmIdpLoginRequest(DialogId);
    }
    /// <summary>
    /// Only valid if the dialog type is ConfirmIdpLogin. Acts as if the user had<br/>
    /// clicked the continue button.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("FedCm.confirmIdpLogin")]
    public record ConfirmIdpLoginRequest(
      [property: Newtonsoft.Json.JsonProperty("dialogId")]
      string DialogId
    ) : ChromeProtocol.Core.ICommand<ConfirmIdpLoginRequestResult>
    {
    }
    public record ConfirmIdpLoginRequestResult() : ChromeProtocol.Core.IType
    {
    }
    public static ChromeProtocol.Domains.FedCm.DismissDialogRequest DismissDialog(string DialogId, bool? TriggerCooldown = default)    
    {
      return new ChromeProtocol.Domains.FedCm.DismissDialogRequest(DialogId, TriggerCooldown);
    }
    [ChromeProtocol.Core.MethodName("FedCm.dismissDialog")]
    public record DismissDialogRequest(
      [property: Newtonsoft.Json.JsonProperty("dialogId")]
      string DialogId,
      [property: Newtonsoft.Json.JsonProperty("triggerCooldown")]
      bool? TriggerCooldown = default
    ) : ChromeProtocol.Core.ICommand<DismissDialogRequestResult>
    {
    }
    public record DismissDialogRequestResult() : ChromeProtocol.Core.IType
    {
    }
    /// <summary>
    /// Resets the cooldown time, if any, to allow the next FedCM call to show<br/>
    /// a dialog even if one was recently dismissed by the user.<br/>
    /// </summary>
    public static ChromeProtocol.Domains.FedCm.ResetCooldownRequest ResetCooldown()    
    {
      return new ChromeProtocol.Domains.FedCm.ResetCooldownRequest();
    }
    /// <summary>
    /// Resets the cooldown time, if any, to allow the next FedCM call to show<br/>
    /// a dialog even if one was recently dismissed by the user.<br/>
    /// </summary>
    [ChromeProtocol.Core.MethodName("FedCm.resetCooldown")]
    public record ResetCooldownRequest() : ChromeProtocol.Core.ICommand<ResetCooldownRequestResult>
    {
    }
    public record ResetCooldownRequestResult() : ChromeProtocol.Core.IType
    {
    }
  }
}