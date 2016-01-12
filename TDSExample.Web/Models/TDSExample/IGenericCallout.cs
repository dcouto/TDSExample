using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace TDSExample.Web.Models.TDSExample
{
    [SitecoreType(TemplateId = "{34DAAF19-012D-4101-BED0-8341679E92B3}", AutoMap = true)]
    public interface IGenericCallout : IStandardTemplate
    {
        string Title { get; set; }

        Image Image { get; set; }

        [SitecoreField(FieldName = "Short Description")]
        string ShortDescription { get; set; }
    }
}