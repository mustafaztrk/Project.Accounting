using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Masraflar;

public interface IMasrafAppService : ICrudAppService<SelectMasrafDto, ListMasrafDto,
    MasrafListParameterDto, CreateMasrafDto, UpdateMasrafDto, CodeParameterDto>
{
}