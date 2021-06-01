using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Strong4Life.web.Utilities
{
    public class UtilityLink
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string Path { get; private set; }


        /// <summary>
        /// Gets the icon key.
        /// </summary>
        /// <value>
        /// The icon key.
        /// </value>
        public string IconKey { get; private set; }

        /// <summary>
        /// Gets a value indicating whether [open in new window].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [open in new window]; otherwise, <c>false</c>.
        /// </value>
        public bool OpenInNewWindow { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityLink"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="path">The path.</param>
        /// <param name="iconKey">The icon key.</param>
        /// <param name="openInNewWindow">if set to <c>true</c> [open in new window].</param>
        public UtilityLink(string title, string path, string iconKey, bool openInNewWindow)
        {
            Title = title;
            Path = path;
            IconKey = iconKey;
            OpenInNewWindow = openInNewWindow;
        }
    }
}