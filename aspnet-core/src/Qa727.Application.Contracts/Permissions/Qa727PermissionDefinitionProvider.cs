using Qa727.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa727.Permissions
{
    public class Qa727PermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Qa727Permissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(Qa727Permissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Qa727Resource>(name);
        }
    }
}
