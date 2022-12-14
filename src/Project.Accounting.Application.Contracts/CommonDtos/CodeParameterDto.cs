using Volo.Abp.Application.Dtos;

namespace Project.Accounting.CommonDtos;

public class CodeParameterDto : IDurum, IEntityDto
{
    public bool Durum { get; set; }
}