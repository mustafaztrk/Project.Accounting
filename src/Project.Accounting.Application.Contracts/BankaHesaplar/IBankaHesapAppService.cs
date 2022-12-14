using Project.Accounting.Services;

namespace Project.Accounting.BankaHesaplar;

public interface IBankaHesapAppService : ICrudAppService<SelectBankaHesapDto,
    ListBankaHesapDto, BankaHesapListParameterDto, CreateBankaHesapDto,
    UpdateBankaHesapDto, BankaHesapCodeParameterDto>
{
}