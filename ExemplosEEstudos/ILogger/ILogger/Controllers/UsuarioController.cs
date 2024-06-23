using ILoggerExemplo.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ILoggerExemplo.Controllers
{
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly ILogger _logger;

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioRepository usuarioRepository)
        {
            _logger = logger;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            _logger.LogInformation("Buscando usuarios, aguarde!");
            var usuarios = _usuarioRepository.Listar();
            _logger.LogInformation($"Foram encontrados {usuarios.Count()} usuarios");
            return Ok(usuarios);
        }
    }
}
