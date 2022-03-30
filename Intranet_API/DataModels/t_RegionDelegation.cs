using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("RegionDelegation")]
    public class t_RegionDelegation
    {
        [Key]
        public int idDelegation { get; set; }
        public int idRegion { get; set; }
        public string Delegation { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
