using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetIdentity.Core
{
    [MetadataType(typeof(CompanyMetaData))]
    public partial class Company
    {
    }

    public partial class CompanyMetaData
    {
        [Required(ErrorMessage = "Company field is required")]
        [DisplayName("Company")]
        public string CompanyName { get; set; }
    }
}
