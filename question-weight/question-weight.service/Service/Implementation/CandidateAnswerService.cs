using question_weight.infra.Models;
using question_weight.infra.Repository;
using question_weight.service.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.service.Service.Implementation
{
    public class CandidateAnswerService : ICandidateAnswerService
    {
        private readonly IRepository<TypeAnswer> repositoryCandidateAnswer;

        public CandidateAnswerService(IRepository<TypeAnswer> repositoryCandidateAnswer)
        {
            this.repositoryCandidateAnswer = repositoryCandidateAnswer;
        }


        public TypeAnswer CreateOrUpdate(TypeAnswer entity)
        {
            try
            {
                return repositoryCandidateAnswer.CreateOrUpdate(entity);
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
                repositoryCandidateAnswer.Delete(id);
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
                return repositoryCandidateAnswer.Get(id);
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
                return repositoryCandidateAnswer.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
