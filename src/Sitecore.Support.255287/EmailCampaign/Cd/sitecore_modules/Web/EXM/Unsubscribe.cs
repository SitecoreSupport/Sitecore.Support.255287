namespace Sitecore.Support.EmailCampaign.Cd.sitecore_modules.Web.EXM
{
  using Sitecore.Modules.EmailCampaign.Core;
  using UnsubscribeOrigin = Sitecore.EmailCampaign.Cd.sitecore_modules.Web.EXM.Unsubscribe;

  public class Unsubscribe : UnsubscribeOrigin
  {
    protected override string LanguageName
    {
      get
      {
        return string.IsNullOrEmpty(ExmContext.Message.TargetLanguage.Name) ? base.LanguageName : ExmContext.Message.TargetLanguage.Name;
      }
    }
  }
}