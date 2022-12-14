using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Cariler;

public interface ICariAppService : ICrudAppService<SelectCariDto, ListCariDto,
    CariListParameterDto, CreateCariDto, UpdateCariDto, CodeParameterDto>
{
}