using Project.Accounting.FaturaHareketler;
using Project.Accounting.Faturalar;
using Project.Accounting.Services;
using Project.Accounting.Stoklar;

namespace Project.Accounting.Depolar;

public interface IDepoHareketAppService : ICrudAppService<SelectFaturaHareketDto,
    ListStokHareketDto, DepoHareketListParameterDto, FaturaHareketDto, FaturaHareketDto,
    FaturaNoParameterDto>
{
    
}