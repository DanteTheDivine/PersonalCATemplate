using Survey.Shared.Abstractions.Exceptions;

namespace Survey.Application.Exceptions
{
    public class SurveyNotFoundException:SurveyException
    {
        public SurveyNotFoundException() : base("Survey Was Not Found")
        {
            
        }
    }
}