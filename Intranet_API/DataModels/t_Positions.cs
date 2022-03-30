using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("Positions")]
    public class t_Positions
    {
        [Key]
        public int idPosition { get; set; }
        public string position { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
