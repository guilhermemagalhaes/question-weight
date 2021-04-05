using question_weight.infra.Models;
using question_weight.infra.Repository;
using question_weight.service.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.service.Service.Implementation
{
    public class CandidateService : ICandidateService
    {
        private readonly IRepository<TypeAnswer> repositoryACandidate;

        public CandidateService(IRepository<TypeAnswer> repositoryACandidate)
        {
            this.repositoryACandidate = repositoryACandidate;
        }


        public TypeAnswer CreateOrUpdate(TypeAnswer entity)
        {
            try
            {
                return repositoryACandidate.CreateOrUpdate(entity);
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
                repositoryACandidate.Delete(id);
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
                return repositoryACandidate.Get(id);
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
                return repositoryACandidate.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
