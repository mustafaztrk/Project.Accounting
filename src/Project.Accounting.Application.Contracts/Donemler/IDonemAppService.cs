using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Donemler;

public interface IDonemAppService : ICrudAppService<SelectDonemDto, ListDonemDto,
    DonemListParameterDto, CreateDonemDto, UpdateDonemDto, CodeParameterDto>
{
}