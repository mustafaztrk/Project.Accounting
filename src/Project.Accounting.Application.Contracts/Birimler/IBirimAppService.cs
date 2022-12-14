using Project.Accounting.CommonDtos;
using Project.Accounting.Services;

namespace Project.Accounting.Birimler;

public interface IBirimAppService : ICrudAppService<SelectBirimDto, ListBirimDto,
    BirimListParameterDto, CreateBirimDto, UpdateBirimDto, CodeParameterDto>
{
}