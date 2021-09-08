using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.XA.Foundation.RenderingVariants.Fields;
using Sitecore.XA.Foundation.Variants.Abstractions.Fields;

namespace SXA.Foundation.Variants.Pipelines.VariantFields
{
    public class VariantImageSection : RenderingVariantFieldBase
    {
        public VariantImageSection(Item variantItem) : base(variantItem)
        {
        }

        public static string DisplayName => "Image Section";

        public IEnumerable<BaseVariantField> SectionFields { get; set; }

        public string ImageFieldName { get; set; }

        public string LinkField { get; set; }

        public bool IsLink { get; set; }
    }
}