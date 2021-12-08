using Volo.Abp.Settings;

namespace Text_Abp.Settings
{
    public class Text_AbpSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Text_AbpSettings.MySetting1));
        }
    }
}
