using Volo.Abp;

namespace Project.Accounting.Exceptions;

public class ConnotBeDeletedException : BusinessException
{
    public ConnotBeDeletedException() : base(AccountingDomainErrorCodes.ConnotBeDeleted)
    {
    }
}