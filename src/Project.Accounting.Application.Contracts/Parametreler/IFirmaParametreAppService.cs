using System;
using System.Threading.Tasks;
using Project.Accounting.Services;

namespace Project.Accounting.Parametreler;

public interface IFirmaParametreAppService : ICrudAppService<SelectFirmaParametreDto,
    SelectFirmaParametreDto, FirmaParametreListParameterDto, CreateFirmaParametreDto,
    UpdateFirmaParametreDto>
{
    Task<bool> UserAnyAsync(Guid userId);
}