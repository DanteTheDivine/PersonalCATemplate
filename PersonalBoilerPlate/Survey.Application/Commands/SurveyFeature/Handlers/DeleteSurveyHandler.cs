using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.SurveyFeature.Handlers
{
    public class DeleteSurveyHandler:IRequestHandler<DeleteSurveyCommand>
    {
        private readonly ISurveyRepository _surveyRepository;

        public DeleteSurveyHandler(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public async Task<Unit> Handle(DeleteSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey = await _surveyRepository.GetById(request.Id);
            if (survey == null)
            {
                throw new SurveyNotFoundException();
            }
            await _surveyRepository.Remove(survey);
            return Unit.Value;
        }
    }
}