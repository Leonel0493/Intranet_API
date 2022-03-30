using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intranet_API.DataModels
{
    [Table("Person")]
    public class t_Person
    {
        [Key]
        public int idPerson { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string thirdName { get; set; }
        public string firstSurname { get; set; }
        public string middleSurname { get; set; }
        public string marriedSurname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int idDelegation { get; set; }
        public string addres { get; set; }
        public string createdBy { get; set; }
        public DateTime cretedDate { get; set; }
        public string modifiedBy { get; set; }
        public DateTime? modifiedDate { get; set; }
        public bool? active { get; set; }
    }
}
