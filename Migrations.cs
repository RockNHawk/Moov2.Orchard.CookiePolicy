using Orchard.ContentManagement.MetaData;
using Orchard.Data.Migration;

namespace Moov2.Orchard.CookiePolicy {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            ContentDefinitionManager.AlterTypeDefinition("CookiePolicy",
                cfg => cfg
                    .WithPart("CookiePolicyPart")
                    .WithPart("CommonPart")
                    .WithPart("WidgetPart")
                    .WithSetting("Stereotype", "Widget")
                    .WithIdentity()
                );

            return 1;
        }
    }
}