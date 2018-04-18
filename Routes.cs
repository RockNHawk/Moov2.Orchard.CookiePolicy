using Orchard.Environment.Extensions;
using Orchard.Mvc.Routes;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace Moov2.Migrate.SEO {
    [OrchardFeature("Moov2.Orchard.CookiePolicy")]
    public class RoutesRobots : IRouteProvider {
        public void GetRoutes(ICollection<RouteDescriptor> routes) {
            foreach (RouteDescriptor routeDescriptor in GetRoutes()) {
                routes.Add(routeDescriptor);
            }
        }
    }
}