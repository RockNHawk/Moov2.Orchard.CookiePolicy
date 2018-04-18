using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;

namespace Moov2.Orchard.CookiePolicy.Models {
    public class CookiePolicyPart : ContentPart {
        internal LazyField<ContentItem> CurrentContentItemField = new LazyField<ContentItem>();

        public ContentItem CurrentContentItem {
            get { return CurrentContentItemField.Value; }
        }
    }
}