using System;
using MediatR;

namespace Survey.Application.Commands.QuestionFeature
{
    public record UpdateQuestionCommand(Guid Id, string Label, string Description) : IRequest;
}