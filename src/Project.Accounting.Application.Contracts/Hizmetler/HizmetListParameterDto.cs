using Project.Accounting.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Hizmetler;

public class HizmetListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}