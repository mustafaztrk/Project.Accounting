using Volo.Abp.Settings;

namespace Project.Accounting.Settings;

public class AccountingSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AccountingSettings.MySetting1));
    }
}
