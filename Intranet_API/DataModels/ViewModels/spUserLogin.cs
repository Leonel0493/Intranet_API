using System.ComponentModel.DataAnnotations;

namespace Intranet_API.DataModels.ViewModels
{
    public class spUserLogin
    {
        [Key]
        public int idEmployee { get; set; }
        public string userName { get; set; }
        public byte[] userPassword { get; set; }
        public int idUnit { get; set; }
        public int idPosition { get; set; }
    }
}
