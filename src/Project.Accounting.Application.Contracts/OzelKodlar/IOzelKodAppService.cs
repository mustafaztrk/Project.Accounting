using Project.Accounting.Services;

namespace Project.Accounting.OzelKodlar;

public interface IOzelKodAppService : ICrudAppService<SelectOzelKodDto, ListOzelKodDto,
    OzelKodListParameterDto, CreateOzelKodDto, UpdateOzelKodDto, OzelKodCodeParameterDto>
{
}