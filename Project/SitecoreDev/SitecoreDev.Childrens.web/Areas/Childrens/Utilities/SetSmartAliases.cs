
using Sitecore.Shell.Framework.Commands;
using SitecoreDev.Childrens.web.Areas.Childrens.Extensions;

namespace SitecoreDev.Childrens.web.Areas.Childrens.Utilities
{
    public class SetSmartAliases : SetAliases
    {
        /// <summary>
        /// Queries the state of the command.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>Query State of the Command</returns>
        public override CommandState QueryState(CommandContext context)
        {
            if (context.Items.Length == 1)
            {
                if (context.Items[0].IsChildrensItem())
                {
                    return CommandState.Disabled;
                }
            }

            return base.QueryState(context);
        }
    }
}