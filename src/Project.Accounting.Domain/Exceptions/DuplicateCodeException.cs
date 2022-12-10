using Volo.Abp;

namespace Project.Accounting.Exceptions;

public class DuplicateCodeException : BusinessException
{
    public DuplicateCodeException(string kod) : base(AccountingDomainErrorCodes.DuplicateKod)
    {
        WithData("kod", kod);
    }
}