using System.Collections.Generic;
using MediatR;
using Survey.Application.DTOS;

namespace Survey.Application.Queries.QuestionFeature
{
    public record GetAllQuestionsQuery() : IRequest<IEnumerable<QuestionDto>>;
}