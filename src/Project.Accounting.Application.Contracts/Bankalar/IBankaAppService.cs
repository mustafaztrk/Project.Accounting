using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Bankalar;

public interface IBankaAppService : ICrudAppService<SelectBankaDto, ListBankaDto,
    BankaListParameterDto, CreateBankaDto, UpdateBankaDto, CodeParameterDto>
{
}