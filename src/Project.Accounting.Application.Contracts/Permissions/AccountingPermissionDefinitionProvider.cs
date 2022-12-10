using Project.Accounting.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Project.Accounting.Permissions;

public class AccountingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AccountingPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AccountingPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AccountingResource>(name);
    }
}
