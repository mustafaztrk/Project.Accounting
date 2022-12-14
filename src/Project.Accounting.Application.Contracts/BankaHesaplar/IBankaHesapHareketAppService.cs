using Project.Accounting.MakbuzHareketler;
using Project.Accounting.Makbuzlar;
using Project.Accounting.OdemeBelgeleri;
using Project.Accounting.Services;

namespace Project.Accounting.BankaHesaplar;

public interface IBankaHesapHareketAppService : ICrudAppService<SelectMakbuzHareketDto, ListOdemeBelgesiHareketDto,
    MakbuzHareketListParameterDto, MakbuzHareketDto, MakbuzHareketDto, MakbuzNoParameterDto>
{
}