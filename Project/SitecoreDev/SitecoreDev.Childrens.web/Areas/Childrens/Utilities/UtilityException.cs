using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Utilities
{
    public class UtilityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityException"/> class.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        public UtilityException(string errorMessage) : base(errorMessage)
        {
            LogUtils.LogError(errorMessage, this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityException" /> class.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public UtilityException(string errorMessage, Exception innerException) : base(errorMessage, innerException)
        {
            LogUtils.LogError(errorMessage, this);
        }
    }
}