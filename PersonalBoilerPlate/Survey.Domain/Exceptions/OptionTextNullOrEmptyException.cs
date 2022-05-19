using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Domain.Exceptions
{
    public class OptionTextNullOrEmptyException:SurveyException
    {
        public OptionTextNullOrEmptyException() : base("Option Text Can Not Be Null Or Empty")
        {
            
        }
    }
}