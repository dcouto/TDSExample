using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;

namespace TDSExample.Web.Models.TDSExample
{
    [SitecoreType(TemplateId = "{1930BBEB-7805-471A-A3BE-4858AC7CF696}")]
    public interface IStandardTemplate
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreParent(InferType = true)]
        IStandardTemplate Parent { get; set; }

        [SitecoreInfo(SitecoreInfoType.BaseTemplateIds)]
        IEnumerable<Guid> BaseTemplateIds { get; set; }

        [SitecoreItem]
        Item SitecoreItem { get; set; }

        [SitecoreChildren(InferType = true)]
        IEnumerable<IStandardTemplate> Children { get; set; }
    }
}