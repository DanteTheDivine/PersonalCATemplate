using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.SurveyFeature.Handlers
{
    public class CreateSurveyHandler:IRequestHandler<CreateSurveyCommand>
    {
        private readonly ISurveyRepository _surveyRepository;

        public CreateSurveyHandler(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public async Task<Unit> Handle(CreateSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey = new Domain.Entity.Survey(request.Title, request.Description);
            await _surveyRepository.Add(survey);
            return Unit.Value;
        }
    }
}