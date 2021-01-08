using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Qa727
{
    [Dependency(ReplaceServices = true)]
    public class Qa727BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qa727";
    }
}
