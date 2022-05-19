using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Survey.Application.Exceptions;
using Survey.Domain.Repository;

namespace Survey.Application.Commands.QuestionFeature.Handlers
{
    public class UpdateQuestionHandler:IRequestHandler<UpdateQuestionCommand>
    {
        private readonly IQuestionRepository _questionRepository;

        public UpdateQuestionHandler(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }
        public async Task<Unit> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = await _questionRepository.GetById(request.Id);
            if (question is null)
            {
                throw new QuestionNotFoundException();
            }
            question.Description = request.Description;
            question.Label = request.Label;
            await _questionRepository.Update(question);
            return Unit.Value;
        }
    }
}