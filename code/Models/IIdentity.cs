using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Sitecore.Feature.Identity.Models
{
    [SitecoreType(TemplateId = Templates.Identity.ID_String)]
    public interface IIdentity
    {
        [SitecoreField(FieldId = Templates.Identity.Fields_String.Logo)]
        Image Logo { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.LogoTagLine)]
        string LogoTagLine { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.Copyright)]
        string Copyright { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.OrganisationName)]
        string OrganisationName { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.OrganisationAddress)]
        string OrganisationAddress { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.OrganisationPhone)]
        string OrganisationPhone { get; set; }

        [SitecoreField(FieldId = Templates.Identity.Fields_String.OrganisationEmail)]
        string OrganisationEmail { get; set; }
    }
}
