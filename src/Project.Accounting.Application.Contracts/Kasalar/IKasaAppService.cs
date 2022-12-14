using Project.Accounting.Services;

namespace Project.Accounting.Kasalar;

public interface IKasaAppService : ICrudAppService<SelectKasaDto, ListKasaDto,
    KasaListParameterDto, CreateKasaDto, UpdateKasaDto, KasaCodeParameterDto>
{
}