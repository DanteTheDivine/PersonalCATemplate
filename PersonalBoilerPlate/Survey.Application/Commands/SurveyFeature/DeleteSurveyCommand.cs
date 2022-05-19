using System;
using MediatR;

namespace Survey.Application.Commands.SurveyFeature
{
    public record DeleteSurveyCommand(Guid Id) : IRequest;
}