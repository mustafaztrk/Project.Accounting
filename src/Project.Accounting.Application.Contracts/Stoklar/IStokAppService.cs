using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Stoklar;

public interface IStokAppService : ICrudAppService<SelectStokDto, ListStokDto,
    StokListParameterDto, CreateStokDto, UpdateStokDto, CodeParameterDto>
{
}