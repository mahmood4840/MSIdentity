using System.Collections.Generic;

namespace AspNetIdentity.Core.Contracts.Repositories
{
    public interface ICompanyRepository
    {
        Company Create(Company model);
        Company GetCompanyById(long Id);
        Company Update(Company model);
        Company Delete(long Id);
        List<Company> GetAll();
    }
}
