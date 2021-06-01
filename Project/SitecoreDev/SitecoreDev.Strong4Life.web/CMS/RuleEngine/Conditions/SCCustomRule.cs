using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using Sitecore.Diagnostics;
using System.Web;

namespace SitecoreDev.Strong4Life.web.CMS.RuleEngine.Conditions
{
    // TODO: Created Sitecore Item "/sitecore/system/Settings/Rules/Common/Conditions/SCCustomRule" when creating SCCustomRule class. Fix Text field.

    public class SCCustomRule<T> : StringOperatorCondition<T> where T : RuleContext
    {
        public string querystringvalue { get; set; }
        protected override bool Execute(T ruleContext)
        {
            bool isPersonalized = false;
            Assert.ArgumentNotNull(ruleContext, "ruleContext");
            var queryStringValueFromRule = this.querystringvalue;
            var queryStringVlaueFromUrl = HttpContext.Current.Request.QueryString["search"];
            if(queryStringVlaueFromUrl== queryStringValueFromRule)
            {
                return true;
            }
            // Return true, if the condition is satisfied.
            return false;
        }
    }
}