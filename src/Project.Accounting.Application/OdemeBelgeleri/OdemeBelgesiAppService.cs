using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Accounting.MakbuzHareketler;
using Project.Accounting.Makbuzlar;
using Project.Accounting.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;

namespace Project.Accounting.OdemeBelgeleri;

[Authorize(AccountingPermissions.OdemeBelgesi.Default)]
public class OdemeBelgesiAppService : AccountingAppService, IOdemeBelgesiAppService
{
    private readonly IOdemeBelgesiRepository _repository;

    public OdemeBelgesiAppService(IOdemeBelgesiRepository repository)
    {
        _repository = repository;
    }

    public virtual async Task<PagedResultDto<ListOdemeBelgesiDto>> GetListAsync(OdemeBelgesiListParameterDto input)
    {
        IList<OdemeBelgesi> _odemeBelgeleri;

        if (input.Sql == "IslemYapilabilecekOdemeBelgeleri")
            _odemeBelgeleri = await _repository.FromSqlRawAsync($"{input.Sql} " +
                                                                $"@SubeId='{input.SubeId}', " +
                                                                $"@DonemId='{input.DonemId}', " +
                                                                $"@KendiBelgemiz={input.KendiBelgemiz}, " +
                                                                $"@OdemeTurleri='{input.OdemeTurleri}'");
        else
            _odemeBelgeleri = await _repository.FromSqlRawAsync($"{input.Sql} " +
                                                                $"@SubeId='{input.SubeId}', " +
                                                                $"@DonemId='{input.DonemId}', " +
                                                                $"@OdemeTurleri='{input.OdemeTurleri}'");

        var mappedEntities = ObjectMapper.Map<List<OdemeBelgesi>, List<ListOdemeBelgesiDto>>(
            _odemeBelgeleri.ToList());
        
        mappedEntities.ForEach(x =>
        {
            x.OdemeTuruAdi = L[$"Enum:OdemeTuru:{(byte)x.OdemeTuru}"];
            x.BelgeDurumuAdi = L[$"Enum:BelgeDurumu:{(byte)x.BelgeDurumu}"];
        });

        return new PagedResultDto<ListOdemeBelgesiDto>
        {
            TotalCount = _odemeBelgeleri.Count,
            Items = mappedEntities
        };
    }

    public Task<SelectMakbuzHareketDto> GetAsync(Guid id) => throw new NotImplementedException();

    public Task<SelectMakbuzHareketDto> CreateAsync(MakbuzHareketDto input) => throw new NotImplementedException();

    public Task<SelectMakbuzHareketDto> UpdateAsync(Guid id, MakbuzHareketDto input) =>
        throw new NotImplementedException();

    public Task DeleteAsync(Guid id) => throw new NotImplementedException();

    public Task<string> GetCodeAsync(MakbuzNoParameterDto input) => throw new NotImplementedException();
}