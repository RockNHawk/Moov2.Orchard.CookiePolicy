using Moov2.Orchard.CookiePolicy.Models;
using Moov2.Orchard.CookiePolicy.Services;
using Orchard.ContentManagement.Handlers;

namespace Moov2.Orchard.CookiePolicy.Handlers {
    public class CookiePolicyHandler : ContentHandler {
        private readonly ICurrentContentAccessor _currentContentAccessor;

        public CookiePolicyHandler(ICurrentContentAccessor currentContentAccessor) {
            _currentContentAccessor = currentContentAccessor;
            OnActivated<CookiePolicyPart>(SetupLazyFields);
        }

        private void SetupLazyFields(ActivatedContentContext context, CookiePolicyPart part) {
            part.CurrentContentItemField.Loader(() => _currentContentAccessor.CurrentContentItem);
        }
    }
}
