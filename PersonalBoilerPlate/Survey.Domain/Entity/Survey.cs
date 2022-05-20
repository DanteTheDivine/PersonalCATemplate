using System;
using System.Collections.Generic;
using Survey.Domain.Exceptions;
using Survey.Shared.Abstractions.Domain;

namespace Survey.Domain.Entity
{
    public class Survey:AuditableEntity
    {
        public string Title
        {
            get => Title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new SurveyTitleNullOrEmptyException();
                }   
            }
        }
        public string Description { get; set; }

        public Survey(string title, string description)
        {
            Title = title;
            Description = description;
            Questions = new List<Question>();
        }

        public Survey(string title)
        {
            Title = title;
            Questions = new List<Question>();
        }
        public ICollection<Question> Questions { get; set; }

        private Survey()
        {
            
        }
    }
}