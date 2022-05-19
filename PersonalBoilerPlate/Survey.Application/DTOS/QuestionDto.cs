using System;
using System.Collections.Generic;
using Survey.Domain.Constants;

namespace Survey.Application.DTOS
{
    public class QuestionDto
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public List<OptionDto> Options { get; set; } = new List<OptionDto>();
        public QuestionType Type { get; set; }
    }
}