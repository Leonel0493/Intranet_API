using System.ComponentModel.DataAnnotations;

namespace Intranet_API.DataModels.AuxilarModel
{
    public class m_Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
