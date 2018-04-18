using Moov2.Orchard.CookiePolicy.Models;
using Orchard.ContentManagement.Drivers;

namespace Moov2.Orchard.CookiePolicy.Drivers {
    public class CookiePolicyDriver : ContentPartDriver<CookiePolicyPart> {
        protected override DriverResult Display(CookiePolicyPart part,
          string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_CookiePolicy", () =>
              shapeHelper.Parts_CookiePolicy());
        }
    }
}
