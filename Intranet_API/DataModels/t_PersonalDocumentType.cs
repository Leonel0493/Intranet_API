using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("PersonalDocumentType")]
    public class t_PersonalDocumentType
    {
        [Key]
        public int idPersonalDocumentType { get; set; }
        public string documentName { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
