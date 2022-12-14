using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Accounting.MakbuzHareketler;

namespace Project.Accounting.Raporlar;

public interface IFinansalDurumAppService
{
    Task<IList<FinansalHareketDto>> KasaSonOnHareketListAsync(MakbuzHareketListParameterDto input);
    Task<IList<FinansalHareketDto>> BankaSonOnHareketListAsync(MakbuzHareketListParameterDto input);
    Task<IList<FinansalDurumDto>> KasaDurumListAsync(MakbuzHareketListParameterDto input);
    Task<IList<FinansalDurumDto>> BankaDurumListAsync(MakbuzHareketListParameterDto input);
    Task<IList<FinansalDurumDto>> OdemeBelgeleriDagilimListAsync(MakbuzHareketListParameterDto input);
    Task<IList<OdemeBelgesiDto>> GecikenAlacaklarListAsync(MakbuzHareketListParameterDto input);
}