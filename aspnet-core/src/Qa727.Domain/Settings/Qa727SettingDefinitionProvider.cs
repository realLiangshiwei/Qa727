using Volo.Abp.Settings;

namespace Qa727.Settings
{
    public class Qa727SettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Qa727Settings.MySetting1));
        }
    }
}
