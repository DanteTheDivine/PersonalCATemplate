using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.SurveyFeature.Handlers
{
    public class UpdateSurveyHandler:IRequestHandler<UpdateSurveyCommand>
    {
        private readonly ISurveyRepository _surveyRepository;

        public UpdateSurveyHandler(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }
        public async Task<Unit> Handle(UpdateSurveyCommand request, CancellationToken cancellationToken)
        {
            var survey =await _surveyRepository.GetById(request.Id);
            if (survey is null)
            {
                throw new SurveyNotFoundException();
            }
            survey.Description = request.Description;
            survey.Title = request.Title;
           await _surveyRepository.Update(survey);
            return Unit.Value;
        }
    }
}