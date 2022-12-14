using System;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Parametreler;

public class UpdateFirmaParametreDto : IEntityDto
{
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid? DepoId { get; set; }
}