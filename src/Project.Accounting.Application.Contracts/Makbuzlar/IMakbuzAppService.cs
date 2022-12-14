using Project.Accounting.Services;

namespace Project.Accounting.Makbuzlar;

public interface IMakbuzAppService : ICrudAppService<SelectMakbuzDto, ListMakbuzDto,
    MakbuzListParameterDto, CreateMakbuzDto, UpdateMakbuzDto, MakbuzNoParameterDto>
{
}