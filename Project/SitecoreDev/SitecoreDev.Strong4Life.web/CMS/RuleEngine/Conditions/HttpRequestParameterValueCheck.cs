using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using Sitecore.Diagnostics;
using System.Web;

namespace SitecoreDev.Strong4Life.web.CMS.RuleEngine.Conditions
{
    // TODO: Created Sitecore Item "/sitecore/system/Settings/Rules/Common/Conditions/HttpRequestParameterValueCheck" when creating HttpRequestParameterValueCheck class. Fix Text field.

    public class HttpRequestParameterValueCheck<T> : StringOperatorCondition<T> where T : RuleContext
    {
        public string ParameterName
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }

        public HttpRequestParameterValueCheck()
        {

        }
        protected override bool Execute(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            if(string.IsNullOrEmpty(this.ParameterName) || string.IsNullOrEmpty(this.Value))
            {
                return false;
            }
            if(string.IsNullOrEmpty(HttpContext.Current.Request.Params.Get(this.ParameterName)))
            {
                return false;
            }
            // Return true, if the condition is satisfied.
            return base.Compare(HttpContext.Current.Request.Params.Get(this.ParameterName),this.Value);
        }
    }
}