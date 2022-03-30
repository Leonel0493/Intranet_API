using Intranet_API.DataModels.AuxilarModel;
using Intranet_API.TransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Intranet_API.Controllers
{
    [ApiController]
    public class AuthController : Controller
    {
        private readonly DataContext _dbContext;
        private readonly ILogger<AuthController> _logger;
        private readonly IConfiguration _config;

        public AuthController(ILogger<AuthController> logger, DataContext _dbContext, IConfiguration config)
        {
            this._logger = logger;
            this._dbContext = _dbContext;
            this._config = config;
        }

        #region GET
        [HttpGet]
        [Route("/[controller]/login")]
        public IActionResult Login([FromBody] m_Login loginInfo)
        {
            if(!ModelState.IsValid)
                return BadRequest("Todos los campos son requeridos");

            var auth = new dto_Employees(_dbContext, _config);

            var userInfo = auth.VerifyCredential(loginInfo);

            if (userInfo == null)
                return BadRequest("Error al iniciar sesion");

            return Ok(userInfo);
        }
        #endregion
    }
}
