using AspNetIdentity.Core.Common;
using System.Collections.Generic;

namespace AspNetIdentity.Core.Contracts.Services
{
    public interface ICompanyService
    {
        ServiceResponse<Company> Create(Company model);
        Company GetCompanyById(long Id);
        Company Update(Company model);
        Company Delete(long Id);
        List<Company> GetAll();
    }
}
