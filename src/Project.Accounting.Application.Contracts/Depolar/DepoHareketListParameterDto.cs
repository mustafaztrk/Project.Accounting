using System;
using Project.Accounting.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Depolar;

public class DepoHareketListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public Guid DepoId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}