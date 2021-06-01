using Sitecore.Configuration;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Pipelines.HttpRequest;
using Sitecore.SecurityModel;
using SitecoreDev.Strong4Life.web.Utilities;

namespace SitecoreDev.Strong4Life.web.CMS.Aliases
{
    // TODO: \App_Config\include\CustomAliasResolver.config created automatically when creating CustomAliasResolver class.

    public class AliasResolver :  HttpRequestProcessor
    {
        /// <summary>
        /// Processes the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public override void Process(HttpRequestArgs args)
        {
            using (new SecurityDisabler())
            {
                if (Sitecore.Context.Site.Name.Equals(SiteUtils.SiteName))
                {
                    if (null == Sitecore.Context.Item)
                    {
                        var aliasItem =
                            Sitecore.Context.Database.GetItem(string.Format("{0}{1}", SiteUtils.GetSiteAliasesPath(),
                                args.LocalPath.ToLower()));
                        
                        if (null != aliasItem)
                        {
                            LinkField linkField = aliasItem.Fields[FieldUtils.Alias.Link];

                            if (null != linkField)
                            {
                                switch (linkField.LinkType.ToLower())
                                {
                                    case "internal":
                                        {
                                            if (null != linkField.TargetItem)
                                            {
                                                if (!string.IsNullOrEmpty(linkField.QueryString.Trim()))
                                                {
                                                    Sitecore.Web.WebUtil.Redirect(linkField.Url);
                                                }
                                                else
                                                {
                                                    Sitecore.Context.Item = linkField.TargetItem;
                                                }
                                            }
                                        }
                                        break;
                                    case "media":
                                        {
                                            if (null != linkField.TargetItem)
                                            {
                                                Sitecore.Web.WebUtil.Redirect(Sitecore.Resources.Media.MediaManager.GetMediaUrl(linkField.TargetItem));
                                            }
                                        }
                                        break;
                                    case "external":
                                        {
                                            args.HttpContext.Response.RedirectPermanent(linkField.Url);
                                        }
                                        break;
                                    default:
                                        { }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
  