using Sitecore.Data;

namespace Sitecore.Feature.Identity
{
    public static class Renderings
    {
        public const string Logo_String = "{A47C8288-7D4C-45FF-B75F-4AEDBF58A02D}";
        public const string Copyright_String = "{7DAE9F23-890F-4E06-99A7-CCEDB74D3D8E}";

        public static readonly ID Logo = new ID(Logo_String);
        public static readonly ID Copyright = new ID(Copyright_String);

        public struct Favicon
        {
            public const string ID_String = "{7F2D4DAA-8D15-45C1-B9A3-E7A4B231E595}";
            public static readonly ID ID = new ID(ID_String);
        }
    }
}
