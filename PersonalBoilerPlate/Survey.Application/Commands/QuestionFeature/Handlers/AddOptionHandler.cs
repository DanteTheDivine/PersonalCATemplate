using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Entity;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.QuestionFeature.Handlers
{
    public class AddOptionHandler:IRequestHandler<AddOptionCommand>
    {
        private readonly IQuestionRepository _questionRepository;

        public AddOptionHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public  async Task<Unit> Handle(AddOptionCommand request, CancellationToken cancellationToken)
        {
            var question =await _questionRepository.GetById(request.Id);
            if (question is null)
            {
                throw new QuestionNotFoundException();
            }
            question.AddOption(request.Text);
            await _questionRepository.Update(question);
            return Unit.Value;
        }
    }
}