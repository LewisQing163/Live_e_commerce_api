using Volo.Abp.Settings;

namespace Live_Commerce.Settings
{
    public class Live_CommerceSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Live_CommerceSettings.MySetting1));
        }
    }
}
