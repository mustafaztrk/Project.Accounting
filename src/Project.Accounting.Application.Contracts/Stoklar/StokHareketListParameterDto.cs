using System;
using Project.Accounting.CommonDtos;
using Project.Accounting.Faturalar;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Stoklar;

public class StokHareketListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public FaturaHareketTuru? HareketTuru { get; set; }
    public Guid StokId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }
}