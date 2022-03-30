using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("PersonalDocument")]
    public class t_PersonalDocument
    {
        [Key]
        public int idPersonalDocument { get; set; }
        public int idPersonalDocumentType { get; set; }
        public int idPerson { get; set; }
        public string number { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
