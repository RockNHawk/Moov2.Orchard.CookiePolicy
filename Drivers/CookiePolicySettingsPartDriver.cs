using Moov2.Orchard.CookiePolicy.Models;
using Orchard.Caching;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace Moov2.Orchard.CookiePolicy.Drivers
{
    public class CookiePolicySettingsPartDriver : ContentPartDriver<CookiePolicySettingsPart>
    {
        private readonly ISignals _signals;
        private const string TemplateName = "Parts.CookiePolicySettings";

        public CookiePolicySettingsPartDriver(ISignals signals)
        {
            _signals = signals;
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        protected override string Prefix
        {
            get { return "CookiePolicySettings"; }
        }

        protected override DriverResult Editor(CookiePolicySettingsPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_CookiePolicySettings_Edit",
                () => shapeHelper.EditorTemplate(TemplateName: TemplateName, Model: part, Prefix: Prefix))
                .OnGroup("CookiePolicy");
        }

        protected override DriverResult Editor(CookiePolicySettingsPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            if (updater.TryUpdateModel(part, Prefix, null, null))
                _signals.Trigger(CookiePolicySettingsPart.CacheKey);

            return Editor(part, shapeHelper);
        }

        protected override void Importing(CookiePolicySettingsPart part, ImportContentContext context)
        {
            _signals.Trigger(CookiePolicySettingsPart.CacheKey);
        }
    }
}
