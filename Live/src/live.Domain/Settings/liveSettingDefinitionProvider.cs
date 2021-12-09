using Volo.Abp.Settings;

namespace live.Settings
{
    public class liveSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(liveSettings.MySetting1));
        }
    }
}
