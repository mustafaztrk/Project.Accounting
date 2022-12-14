using System;
using Volo.Abp.Application.Services;

namespace Project.Accounting.Services;

public interface ICrudAppService
    <TGetOutputDto,//tek parametre donerken yani select ile başlayan dto lar için
    TGetListOutputDto,//liste dto lar için 
    in TGetListInput,// başında in yazanlar veri girişi olanlar
    in TCreateInput,
    in TUpdateInput> :
    IReadOnlyAppService<TGetOutputDto, TGetListOutputDto, Guid, TGetListInput>,
    ICreateAppService<TGetOutputDto, TCreateInput>,
    IUpdateAppService<TGetOutputDto, Guid, TUpdateInput>
{
}

public interface ICrudAppService<TGetOutputDto, TGetListOutputDto, in TGetListInput,
    in TCreateInput, in TUpdateInput, in TGetCodeInput> :
    ICrudAppService<TGetOutputDto, TGetListOutputDto, TGetListInput,
    TCreateInput, TUpdateInput>,
    IDeleteAppService<Guid>,
    ICodeAppService<TGetCodeInput>
{
}