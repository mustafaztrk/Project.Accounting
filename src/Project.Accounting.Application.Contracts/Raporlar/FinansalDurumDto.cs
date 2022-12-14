using Volo.Abp.Application.Dtos;

namespace Project.Accounting.Raporlar;

public class FinansalDurumDto : IEntityDto
{
    public decimal Tutar { get; set; }
    public string Aciklama { get; set; }
}