using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.QuestionFeature.Handlers
{
    public class RemoveQuestionHandler:IRequestHandler<RemoveQuestionCommand>
    {
        private readonly IQuestionRepository _questionRepository;

        public RemoveQuestionHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task<Unit> Handle(RemoveQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = await _questionRepository.GetById(request.Id);
            if (question == null)
            {
                throw new QuestionNotFoundException();
            }

            await _questionRepository.Remove(question);
            return  Unit.Value;
        }
    }
}