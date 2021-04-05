using question_weight.infra.Models;
using question_weight.infra.Repository;
using question_weight.service.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.service.Service.Implementation
{
    public class AnswerService : IAnswerService
    {
        private readonly IRepository<Answer> repositoryAnswer;

        public AnswerService(IRepository<Answer> repositoryAnswer)
        {
            this.repositoryAnswer = repositoryAnswer;
        }


        public Answer CreateOrUpdate(Answer entity)
        {
            try
            {
                return repositoryAnswer.CreateOrUpdate(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(long id)
        {
            try
            {
                repositoryAnswer.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Answer Get(long id)
        {
            try
            {
                return repositoryAnswer.Get(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Answer> GetAll()
        {
            try
            {
                return repositoryAnswer.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
