using Orchard;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.DisplayManagement;
using Orchard.Environment.Extensions;
using Orchard.Localization;
using Orchard.Security;
using Orchard.UI.Admin;
using Orchard.UI.Notify;
using System.Linq;
using System.Web.Mvc;

namespace Moov2.Orchard.CookiePolicy.Controllers {
    [OrchardFeature("Moov2.Orchard.CookiePolicy")]
    [ValidateInput(false), Admin]
    public class AdminController : Controller {
        #region Dependencies

        public Localizer T { get; set; }

        private readonly IContentManager _contentManager;
        private readonly IOrchardServices _orchardServices;
        private readonly IAuthorizer _authorizer;


        dynamic Shape { get; set; }

        #endregion

        #region Constructor

        public AdminController(IContentManager contentManager, IOrchardServices orchardServices, IShapeFactory shapeFactory, IAuthorizer authorizer) {
            _contentManager = contentManager;
            _orchardServices = orchardServices;
            _authorizer = authorizer;

            Shape = shapeFactory;
            T = NullLocalizer.Instance;
        }

        #endregion

        #region Actions

        public ActionResult Index() {
            if (!_authorizer.Authorize(StandardPermissions.AccessAdminPanel))
                return new HttpUnauthorizedResult();

            return View();
        }

        #endregion
    }
}