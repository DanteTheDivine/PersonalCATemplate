using System;
using MediatR;

namespace Survey.Application.Commands.QuestionFeature
{
    public record AddOptionCommand(Guid Id, string Text) : IRequest;
}