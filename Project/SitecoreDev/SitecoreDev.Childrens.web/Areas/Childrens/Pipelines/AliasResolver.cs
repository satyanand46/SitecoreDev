using Sitecore.Pipelines.HttpRequest;
using Sitecore.Configuration;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.SecurityModel;
using SitecoreDev.Childrens.web.Areas.Childrens.Utilities;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Pipelines
{
    // TODO: \App_Config\include\AliasResolver.config created automatically when creating AliasResolver class.

    public class AliasResolver : HttpRequestProcessor
    {
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

                        //var aliasItem= getAliasItem(args);
                        Tracer.Warning((object)"There is no context database.");
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

        /// 

        /// Gets the alias item.
        /// 

        /// The args.
        /// 
        private Item getAliasItem(HttpRequestArgs args)
        {
            string siteName = Sitecore.Context.Site.RootPath.ToLower();

            if (args.LocalPath.Length > 1)
            {
                Item aliasItem = Sitecore.Context.Database.GetItem("/sitecore/content/Childrens/Components/Aliases/" + args.LocalPath);
                if (aliasItem != null)
                {
                    return aliasItem;
                }
            }

            return null;
        }
    }
}