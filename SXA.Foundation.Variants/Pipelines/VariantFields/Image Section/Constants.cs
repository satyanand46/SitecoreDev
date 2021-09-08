using Sitecore.Data;

namespace SXA.Foundation.Variants.Pipelines.VariantFields
{
    public static partial class Constants
    {
        public static partial class RenderingVariants
        {
            public static partial class Templates
            {
                public static ID VariantImageSection = new ID("{B7D669DB-A5AC-4A88-94B5-8701034E3E2C}");
            }

            public static partial class Fields
            {
                public static class ImageSection
                {
                    public static ID ImageField { get; } = new ID("{56D2F909-5187-4930-AAB6-5946514BF2FD}");
                    public static ID Tag { get; } = new ID("{BF6BDA82-4DF9-4518-BC8A-60BF2EE589B7}");
                    public static ID CssClass { get; } = new ID("{D6DDEFF5-9FC7-4151-8CA2-F3575A48C3AE}");
                    public static ID IsLink { get; } = new ID("{93975B31-C74D-48E8-8A95-399FDFBA6A08}");
                }

            }
        }
    }
}