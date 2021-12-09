using live.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace live.Permissions
{
    public class livePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(livePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(livePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<liveResource>(name);
        }
    }
}
