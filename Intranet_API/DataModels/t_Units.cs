using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("Units")]
    public class t_Units
    {
        [Key]
        public int idUnit { get; set; }
        public int idDepartment { get; set; }
        public string unit { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
