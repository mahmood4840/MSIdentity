using AspNetIdentity.Core;
using AspNetIdentity.Core.Contracts.Repositories;
using System;
using System.Collections.Generic;

namespace AspNetIdentity.Repository.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        //private readonly AspNetIdentityEntities db = new AspNetIdentityEntities();

        public Company Create(Company model)
        {
            try
            {
               // model.CreatedOn = DateTime.Now;
               // db.Companies.Add(model);
               // db.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Company Delete(long Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Company GetCompanyById(long Id)
        {
            throw new System.NotImplementedException();
        }

        public Company Update(Company model)
        {
            throw new System.NotImplementedException();
        }
    }
}
