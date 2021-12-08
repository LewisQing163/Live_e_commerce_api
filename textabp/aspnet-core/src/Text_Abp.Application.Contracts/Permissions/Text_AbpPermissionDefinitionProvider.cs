using Text_Abp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Text_Abp.Permissions
{
    public class Text_AbpPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Text_AbpPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Text_AbpPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Text_AbpResource>(name);
        }
    }
}
