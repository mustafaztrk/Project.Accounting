using Project.Accounting.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Bankalar;

public class BankaListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    //bankalar listelenirken aktif/pasif durumua göre listelencek
    public bool Durum { get; set; }
}