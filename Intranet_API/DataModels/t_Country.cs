using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("Country")]
    public class t_Country
    {
        [Key]
        public int idCountry { get; set; }
        public string countryName { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
