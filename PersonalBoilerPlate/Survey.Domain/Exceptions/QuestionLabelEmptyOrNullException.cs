using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Domain.Exceptions
{
    public class QuestionLabelEmptyOrNullException:SurveyException
    {
        public QuestionLabelEmptyOrNullException( ) : base("The Question Label Can Not Be Empty Or Null")
        {
        }
    }
}