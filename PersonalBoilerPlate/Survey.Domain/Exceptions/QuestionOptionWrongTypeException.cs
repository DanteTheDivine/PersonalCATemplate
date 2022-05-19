using Survey.Domain.Entity;
using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Domain.Exceptions
{
    public class QuestionOptionWrongTypeException:SurveyException
    {
        public Question Question { get; private set; }

        public QuestionOptionWrongTypeException(Question question) : base($"The '{question.Label}' is of type {question.QuestionType}, and can not contain options. ")
        {
            Question = question;
        }
    }
}