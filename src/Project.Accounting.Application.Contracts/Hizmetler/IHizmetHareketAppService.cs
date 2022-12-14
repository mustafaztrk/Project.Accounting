using Project.Accounting.FaturaHareketler;
using Project.Accounting.Faturalar;
using Project.Accounting.Services;

namespace Project.Accounting.Hizmetler;

public interface IHizmetHareketAppService : ICrudAppService<SelectFaturaHareketDto,
    ListHizmetHareketDto, HizmetHareketListParameterDto, FaturaHareketDto, FaturaHareketDto,
    FaturaNoParameterDto>
{
    
}