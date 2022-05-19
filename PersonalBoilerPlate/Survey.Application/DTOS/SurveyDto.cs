using System;

namespace Survey.Application.DTOS
{
    public record SurveyDto(Guid Id, string Title, string Description);
}