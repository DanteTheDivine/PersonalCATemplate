using System.Collections.Generic;
using MediatR;
using Survey.Application.DTOS;

namespace Survey.Application.Queries.SurveyFeature
{
    public record GetAllSurveyQuery() : IRequest<ICollection<SurveyDto>>;
}