using System;
using System.Threading.Tasks;

namespace Survey.Domain.Repository
{
    public interface ISurveyRepository
    {
        Task Add(Entity.Survey survey);
        Task Remove(Entity.Survey survey);
        Task<Entity.Survey> GetById(Guid id);
        Task Update(Entity.Survey survey);
    }
}