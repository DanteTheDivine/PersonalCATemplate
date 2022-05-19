using MediatR;
using Survey.Domain.Constants;

namespace Survey.Application.Commands.QuestionFeature
{
    public record CreateQuestionCommand(string Label, string Description, QuestionType Type):IRequest;
}