using MediatR;

namespace Survey.Application.Commands.SurveyFeature
{
    public record CreateSurveyCommand(string Title,string Description) : IRequest;
}