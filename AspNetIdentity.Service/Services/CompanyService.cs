using AspNetIdentity.Core;
using AspNetIdentity.Core.Contracts.Repositories;
using AspNetIdentity.Core.Contracts.Services;
using System;
using System.Collections.Generic;
using AspNetIdentity.Core.Common;
using AspNetIdentity.Utilities;

namespace AspNetIdentity.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public ServiceResponse<Company> Create(Company model)
        {
            var response = new ServiceResponse<Company>();
            try
            {
                var result = _companyRepository.Create(model);
                if (result == null)
                    response.Message = "Company is not created, something went wrong";
                else
                {
                    response.Success = true;
                    response.Result = result;
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.GetMessage();
            }
            return response;
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
