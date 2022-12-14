using System;
using Project.Accounting.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Depolar;

public class DepoListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}