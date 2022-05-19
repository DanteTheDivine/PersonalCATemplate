using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Domain.Exceptions
{
    public class SurveyTitleNullOrEmptyException:SurveyException
    {
        public SurveyTitleNullOrEmptyException() : base("The Survey Title Can Not Be Null Or Empty")
        {
        }
    }
}