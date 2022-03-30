using Intranet_API.DataModels.AuxilarModel;
using Intranet_API.DataModels.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Intranet_API.TransferObjects
{
    public class dto_Employees
    {
        private readonly DataContext _dbContex;
        private readonly IConfiguration _config;

        public dto_Employees(DataContext _dbContext, IConfiguration configuration)
        {
            this._dbContex = _dbContext;
            this._config = configuration;
        }

        #region Auth
        public async Task<m_UserInfo> VerifyCredential(m_Login userData)
        {
            try
            {
                var resp = _dbContex.UserLogin.FromSqlRaw<spUserLogin>("Exec sp_VerifyCredentials @userName, @userPassword", new SqlParameter("@userName", userData.UserName),
                                                    new SqlParameter("@userPassword", userData.Password)).ToList();

                if (resp == null)
                    return null;

                m_UserInfo userInfo = new m_UserInfo
                {
                    idEmployee = resp.First().idEmployee,
                    idPosition = resp.First().idPosition,
                    idUnit = resp.First().idUnit,
                    userName = resp.First().userName,
                    userPassword = resp.First().userPassword
                };

                userInfo.jwt = CreateToken(userInfo);

                return userInfo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string CreateToken(m_UserInfo user)
        {
            try
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.userName)
                };

                var jwtSetting = _config.GetSection("IntraSettings");
                var jwtKey = jwtSetting.GetSection("Token").Value;

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtKey));

                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var token = new JwtSecurityToken(
                        claims: claims, 
                        expires: DateTime.Now.AddDays(1), 
                        signingCredentials: cred
                    );

                var jwt = new JwtSecurityTokenHandler().WriteToken(token);

                return jwt;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Employees
        //public async Task<v_EmployeeInfo> GetEmployeeInfo(int idEmployee)
        //{
        //    var employeeInfo = await _dbContex.v_EmployeeInfos.FirstAsync(x => x.idEmployee == idEmployee);

        //    return employeeInfo;
        //}

        //public async Task<List<v_EmployeeInfo>> GetEmployees()
        //{
        //    var lstEmployees = await _dbContex.v_EmployeeInfos.Where(x => x.active == true).ToListAsync();

        //    return lstEmployees;
        //}
        #endregion
    }
}
