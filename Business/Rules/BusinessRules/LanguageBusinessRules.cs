using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class LanguageBusinessRules : BaseBusinessRules
{
    ILanguageDal _languageDal;

    public LanguageBusinessRules(ILanguageDal languageDal)
    {
        _languageDal = languageDal;
    }

    public async Task IsExistsLanguage(Guid languageId)
    {
        var result = await _languageDal.GetAsync(
            predicate: a => a.Id == languageId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
