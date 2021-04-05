using question_weight.infra.Models;
using question_weight.infra.Repository;
using question_weight.service.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_weight.service.Service.Implementation
{
    public class TypeAnswerService : ITypeAnswerService
    {
        private readonly IRepository<TypeAnswer> repositoryTypeAnswer;

        public TypeAnswerService(IRepository<TypeAnswer> repositoryTypeAnswer)
        {
            this.repositoryTypeAnswer = repositoryTypeAnswer;
        }


        public TypeAnswer CreateOrUpdate(TypeAnswer entity)
        {
            try
            {
                return repositoryTypeAnswer.CreateOrUpdate(entity);
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
                repositoryTypeAnswer.Delete(id);
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
                return repositoryTypeAnswer.Get(id);
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
                return repositoryTypeAnswer.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
