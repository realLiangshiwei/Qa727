using System;
using System.Collections.Generic;
using System.Text;
using Qa727.Localization;
using Volo.Abp.Application.Services;

namespace Qa727
{
    /* Inherit your application services from this class.
     */
    public abstract class Qa727AppService : ApplicationService
    {
        protected Qa727AppService()
        {
            LocalizationResource = typeof(Qa727Resource);
        }
    }
}
