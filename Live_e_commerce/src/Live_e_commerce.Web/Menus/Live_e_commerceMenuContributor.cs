using System.Threading.Tasks;
using Live_e_commerce.Localization;
using Live_e_commerce.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Live_e_commerce.Web.Menus
{
    public class Live_e_commerceMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<Live_e_commerceResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    Live_e_commerceMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
            
            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
        }
    }
}
