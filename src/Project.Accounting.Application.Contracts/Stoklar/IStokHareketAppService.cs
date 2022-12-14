using Project.Accounting.FaturaHareketler;
using Project.Accounting.Faturalar;
using Project.Accounting.Services;

namespace Project.Accounting.Stoklar;

public interface IStokHareketAppService : ICrudAppService<SelectFaturaHareketDto,
    ListStokHareketDto, StokHareketListParameterDto, FaturaHareketDto, FaturaHareketDto,
    FaturaNoParameterDto>
{
}