using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Domain.Entity;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.QuestionFeature.Handlers
{
    public class CreateQuestionHandler:IRequestHandler<CreateQuestionCommand>
    {
        private readonly IQuestionRepository _questionRepository;

        public CreateQuestionHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task<Unit> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            Question question = new Question(request.Label, request.Type,request.Description);
            await _questionRepository.Add(question);
            return Unit.Value;
        }
    }
}