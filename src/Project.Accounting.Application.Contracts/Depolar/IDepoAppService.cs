using Project.Accounting.Services;

namespace Project.Accounting.Depolar;

public interface IDepoAppService : ICrudAppService<SelectDepoDto, ListDepoDto,
    DepoListParameterDto, CreateDepoDto, UpdateDepoDto, DepoCodeParameterDto>
{
}