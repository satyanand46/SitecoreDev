using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Strong4Life.web.Utilities
{
    public class LogUtils
    {
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public static void LogError(string message, Exception exception)
        {
            Sitecore.Diagnostics.Log.Error(string.Format("{0} (site name: {1})", message, SiteUtils.SiteName), exception);
        }

        public static void LogInfo(string message, object owner)
        {
            Sitecore.Diagnostics.Log.Info(string.Format("{0} (site name: {1})", message, SiteUtils.SiteName), owner);
        }
    }
}