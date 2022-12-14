using Project.Accounting.Services;

namespace Project.Accounting.Faturalar;

public interface IFaturaAppService : ICrudAppService<SelectFaturaDto, ListFaturaDto,
    FaturaListParameterDto, CreateFaturaDto, UpdateFaturaDto, FaturaNoParameterDto>
{
}