using Project.Accounting.FaturaHareketler;
using Project.Accounting.Faturalar;
using Project.Accounting.Services;

namespace Project.Accounting.Masraflar;

public interface IMasrafHareketAppService: ICrudAppService<SelectFaturaHareketDto,
    ListMasrafHareketDto, MasrafHareketListParameterDto, FaturaHareketDto, FaturaHareketDto,
    FaturaNoParameterDto>
{
    
}