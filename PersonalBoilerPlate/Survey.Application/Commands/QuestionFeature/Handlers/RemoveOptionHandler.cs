using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.QuestionFeature.Handlers
{
    public class RemoveOptionHandler : IRequestHandler<RemoveOptionCommand>
    {
        private readonly IQuestionRepository _questionRepository;

        public RemoveOptionHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<Unit> Handle(RemoveOptionCommand request, CancellationToken cancellationToken)
        {
            var question = await _questionRepository.GetById(request.QuestionId);
            if (question is  null)
            {
                throw new QuestionNotFoundException();
            }
            question.RemoveOption(request.OptionId);
            await _questionRepository.Update(question);
            return Unit.Value;
        }
    }
}