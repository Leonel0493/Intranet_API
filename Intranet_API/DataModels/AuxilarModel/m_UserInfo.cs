

namespace Intranet_API.DataModels.AuxilarModel
{
    public class m_UserInfo
    {
        public int idEmployee { get; set; }
        public string userName { get; set; }
        public byte[] userPassword { get; set; }
        public int idUnit { get; set; }
        public int idPosition { get; set; }

        public string? jwt { get; set; }
    }
}
