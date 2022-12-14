using Project.Accounting.Services;

namespace Project.Accounting.BankaSubeler;

public interface IBankaSubeAppService : ICrudAppService<SelectBankaSubeDto, ListBankaSubeDto,
    BankaSubeListParameterDto, CreateBankaSubeDto, 
    UpdateBankaSubeDto, BankaSubeCodeParameterDto>
{
}