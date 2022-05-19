using System;
using System.Collections.Generic;
using System.Linq;
using Survey.Domain.Constants;
using Survey.Domain.Exceptions;
using Survey.Shared.Abstractions.Domain;

namespace Survey.Domain.Entity
{
    public class Question:BaseEntityIdentity<Guid,Guid>
    {
        public string Label
        {
            get => Label;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new QuestionLabelEmptyOrNullException();
                }
            } }
        public string Description { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<Option> Options { get; set; }
        public Guid SurveyId { get; set; }
        public Question(string label,QuestionType questionType)
        {
            Label = label;
            QuestionType = questionType;
            Options = new List<Option>();

        }
        public Question(string label,QuestionType questionType,string description):this(label,questionType)
        {
            Description = description;
            
        }

        private Question()
        {
            
        }

        public void AddOption(string optionText)
        {
            if (QuestionType != QuestionType.MultiSelect && QuestionType != QuestionType.SelectOne)
            {
                throw new QuestionOptionWrongTypeException(this);
            }
            Option option = new Option(optionText);
            Options.Add(option);
        }

        public void RemoveOption(Guid id)
        {
            Option option = Options.FirstOrDefault(x => x.Id == id);
            if (option is null)
            {
                return;
            }

            Options.Remove(option);
        }
    }
}