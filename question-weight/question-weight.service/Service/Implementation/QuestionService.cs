using question_weight.infra.Models;
using question_weight.infra.Repository;
using question_weight.service.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.service.Service.Implementation
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<TypeAnswer> repositoryQuestion;

        public QuestionService(IRepository<TypeAnswer> repositoryQuestion)
        {
            this.repositoryQuestion = repositoryQuestion;
        }


        public TypeAnswer CreateOrUpdate(TypeAnswer entity)
        {
            try
            {
                return repositoryQuestion.CreateOrUpdate(entity);
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
                repositoryQuestion.Delete(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TypeAnswer Get(long id)
        {
            try
            {
                return repositoryQuestion.Get(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<TypeAnswer> GetAll()
        {
            try
            {
                return repositoryQuestion.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
