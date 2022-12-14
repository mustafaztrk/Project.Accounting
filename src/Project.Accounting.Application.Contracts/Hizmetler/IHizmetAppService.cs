using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Hizmetler;

public interface IHizmetAppService : ICrudAppService<SelectHizmetDto, ListHizmetDto,
    HizmetListParameterDto, CreateHizmetDto, UpdateHizmetDto, CodeParameterDto>
{
}