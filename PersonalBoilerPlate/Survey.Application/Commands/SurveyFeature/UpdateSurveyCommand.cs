using System;
using MediatR;

namespace Survey.Application.Commands.SurveyFeature
{
    public record UpdateSurveyCommand(Guid Id, string Title, string Description) : IRequest;
}