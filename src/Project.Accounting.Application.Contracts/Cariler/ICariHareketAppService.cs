using Project.Accounting.MakbuzHareketler;
using Project.Accounting.Makbuzlar;
using Project.Accounting.Services;

namespace Project.Accounting.Cariler;

public interface ICariHareketAppService : ICrudAppService<SelectMakbuzHareketDto, ListCariHareketDto,
CariHareketListParameterDto, MakbuzHareketDto, MakbuzHareketDto, MakbuzNoParameterDto>
{
    
}