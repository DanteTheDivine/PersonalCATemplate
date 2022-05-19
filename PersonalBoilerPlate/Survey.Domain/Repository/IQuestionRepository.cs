using System;
using System.Threading.Tasks;
using Survey.Domain.Entity;

namespace Survey.Domain.Repository
{
    public interface IQuestionRepository
    {
        Task<Question> GetById(Guid id);
        Task Update(Question question);
        Task Remove(Question question);
        Task Add(Question question);
    }
}