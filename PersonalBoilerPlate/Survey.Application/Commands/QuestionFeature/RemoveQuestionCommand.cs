using System;
using MediatR;

namespace Survey.Application.Commands.QuestionFeature
{
    public record RemoveQuestionCommand(Guid Id):IRequest;
}