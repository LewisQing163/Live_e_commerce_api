using Live_Commerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Live_Commerce.Permissions
{
    public class Live_CommercePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Live_CommercePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Live_CommercePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Live_CommerceResource>(name);
        }
    }
}
