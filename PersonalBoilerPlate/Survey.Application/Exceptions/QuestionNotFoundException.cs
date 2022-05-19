using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Application.Exceptions
{
    public class QuestionNotFoundException:SurveyException
    {
        public QuestionNotFoundException() : base("Question Was Not Found")
        {
        }
    }
}