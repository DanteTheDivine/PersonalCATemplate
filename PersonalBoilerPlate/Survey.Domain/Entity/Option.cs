using System;
using Survey.Domain.Exceptions;
using Survey.Shared.Abstractions.Domain;

namespace Survey.Domain.Entity
{
    public class Option:BaseEntity<Guid>
    {
        public string OptionText
        {
            get => OptionText;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new OptionTextNullOrEmptyException();
                }
            } 
        }

        public Option(string optionText)
        {
            OptionText = optionText;
        }

        private Option()
        {
            
        }
    }
}