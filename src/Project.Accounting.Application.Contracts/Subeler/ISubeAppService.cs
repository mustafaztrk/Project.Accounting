using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Subeler;

public interface ISubeAppService : ICrudAppService<SelectSubeDto, ListSubeDto,
    SubeListParameterDto, CreateSubeDto, UpdateSubeDto, CodeParameterDto>
{
}