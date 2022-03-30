using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("Employees")]
    public class t_Employees
    {
        [Key]
        public int idEmployee { get; set; }
        public int idPerson { get; set; }
        public string userName { get; set; }
        public byte[] userPassword { get; set; }
        public int idUnit { get; set; }
        public int idPosition { get; set; }
        public DateTime admissionDate { get; set; }
        public string academicDegree { get; set; }
        public string profession { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
