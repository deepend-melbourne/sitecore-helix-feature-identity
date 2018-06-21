using Sitecore.Data;

namespace Sitecore.Feature.Identity
{
    public struct Templates
    {
        public struct Identity
        {
            public const string ID_String = "{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}";
            public static readonly ID ID = new ID(ID_String);

            public struct Fields
            {
                public static readonly ID Logo = new ID(Fields_String.Logo);
                public static readonly ID LogoTagLine = new ID(Fields_String.LogoTagLine);
                public static readonly ID Copyright = new ID(Fields_String.Copyright);
                public static readonly ID OrganisationName = new ID(Fields_String.OrganisationName);
                public static readonly ID OrganisationAddress = new ID(Fields_String.OrganisationAddress);
                public static readonly ID OrganisationPhone = new ID(Fields_String.OrganisationPhone);
                public static readonly ID OrganisationEmail = new ID(Fields_String.OrganisationEmail);
                public static readonly ID Favicon = new ID(Fields_String.Favicon);
            }

            public struct Fields_String
            {
                public const string Logo = "{E748D808-64C1-4DEC-9718-F35CF9689E4B}";
                public const string LogoTagLine = "{31D027BB-FAB5-4E1A-A66D-9F5B0FD4F005}";
                public const string Copyright = "{02115632-FE1E-4B3D-9AD4-A4DDF1F782F0}";
                public const string OrganisationName = "{EFD4980A-030C-497C-8880-40B6030AC28B}";
                public const string OrganisationAddress = "{A24DF48F-C8A3-4163-966C-8C24BD8760B2}";
                public const string OrganisationPhone = "{005ED83C-2D2F-4D07-A7A9-EB64D873DE46}";
                public const string OrganisationEmail = "{9C428556-5D7B-46AC-B0BB-B06A4F4C9591}";
                public const string Favicon = "{0390FD7E-F1A8-454A-9FC4-DA79F6F8D7EA}";
            }
        }
    }
}
