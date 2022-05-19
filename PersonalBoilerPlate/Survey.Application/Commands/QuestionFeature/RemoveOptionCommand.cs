using System;
using MediatR;

namespace Survey.Application.Commands.QuestionFeature
{
    public record RemoveOptionCommand(Guid QuestionId,Guid OptionId) : IRequest;
}