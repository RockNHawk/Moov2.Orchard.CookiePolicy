using Moov2.Orchard.CookiePolicy.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace Moov2.Orchard.CookiePolicy.Handlers
{
    public class CookiePolicySettingsPartHandler : ContentHandler
    {
        public CookiePolicySettingsPartHandler()
        {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<CookiePolicySettingsPart>("Site"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            if (context.ContentItem.ContentType != "Site")
                return;

            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Cookie Policy"))
            {
                Id = "CookiePolicy",
                Position = "3"
            });
        }
    }
}