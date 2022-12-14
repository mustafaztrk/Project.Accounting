using Project.Accounting.MakbuzHareketler;
using Project.Accounting.Makbuzlar;
using Project.Accounting.Services;

namespace Project.Accounting.OdemeBelgeleri;

public interface IOdemeBelgesiAppService : ICrudAppService<SelectMakbuzHareketDto, ListOdemeBelgesiDto,
    OdemeBelgesiListParameterDto, MakbuzHareketDto, MakbuzHareketDto, MakbuzNoParameterDto>
{
}