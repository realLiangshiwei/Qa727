using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Qa727
{
    [Dependency(ReplaceServices = true)]
    public class Qa727BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qa727";
    }
}
