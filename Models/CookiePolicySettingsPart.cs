using Orchard.ContentManagement;
using Orchard.ContentManagement.FieldStorage.InfosetStorage;

namespace Moov2.Orchard.CookiePolicy.Models
{
    public class CookiePolicySettingsPart : ContentPart
    {
        public const string CacheKey = "CookiePolicySettingsPart";

        public string Description
        {
            get { return this.As<InfosetPart>().Get<CookiePolicySettingsPart>("Description"); }
            set { this.As<InfosetPart>().Set<CookiePolicySettingsPart>("Description", string.IsNullOrEmpty(value) ? string.Empty : value.ToString()); }
        }
    }
}