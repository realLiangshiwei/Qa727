using Qa727.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qa727.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Qa727Controller : AbpController
    {
        protected Qa727Controller()
        {
            LocalizationResource = typeof(Qa727Resource);
        }
    }
}