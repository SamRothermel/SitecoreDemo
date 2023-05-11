using Sitecore.Data;

namespace SitecoreDemo.Feature.Header.Templates
{
    public struct HeaderItem
    {
        public static readonly ID Id = new ID(IdString);
        public const string IdString = "{6E4835C8-B6E9-40A4-906B-0B282BC1D155}";
    }

    public struct HeaderLinkItem
    {
        public static readonly ID Id = new ID(IdString);
        public const string IdString = "{5593EED1-8F3C-4426-87CA-BCFE0DC16C01}";
    }

    public struct PageItem
    {
        public static readonly ID id = new ID(IdString);
        public const string IdString = "{91EFF004-28FA-4558-BFAC-6021E9AFD08E}";
    }
}