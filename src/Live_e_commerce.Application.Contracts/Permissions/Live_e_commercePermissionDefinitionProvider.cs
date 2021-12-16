using Live_e_commerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Live_e_commerce.Permissions
{
    public class Live_e_commercePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Live_e_commercePermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Live_e_commercePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Live_e_commerceResource>(name);
        }
    }
}
