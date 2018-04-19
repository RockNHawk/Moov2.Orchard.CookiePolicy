using Orchard.UI.Resources;

namespace Moov2.Orchard.CookiePolicy {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();
            manifest.DefineStyle("CookiePolicy").SetUrl("CookiePolicy.min.css", "CookiePolicy.css");
            manifest.DefineScript("CookiePolicy").SetUrl("CookiePolicy.min.js", "CookiePolicy.js");
        }
    }
}