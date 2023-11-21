using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using ComprarJogo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteDAO clienteDAO;
        private readonly ClienteService clienteService;
        private readonly CompraDbContext dbContext;

        public ClienteController(IClienteDAO clienteDAO,ClienteService clienteService, CompraDbContext dbContext)
        {
            this.clienteDAO = clienteDAO;
            this.clienteService = clienteService;
            this.dbContext = dbContext;
            
        }

        [HttpGet("/BuscarTodosClientes")]
        public  ActionResult<List<Cliente>> BuscarTodos()
        {
            List<Cliente> clientes = clienteDAO.BuscarTodos();
            return Ok(clientes);
        }

        [HttpGet("/Logar")]
        public ActionResult<Cliente> Logar(string email, string senha)
        {
            bool logado =  clienteService.Logar(email, senha);
            return Ok(logado);
        }

        [HttpGet("/BuscarPorEmail")]
        public ActionResult<List<Cliente>> BuscarPorEmail(string email)
        {
            Cliente cliente =  clienteDAO.BuscarPorEmail(email);
            return Ok(cliente);
        }

        [HttpPost("/AdicionarCliente")]
        public ActionResult<Cliente> AdicionarCliente([FromBody] Cliente cliente)
        {
            Cliente clienteCadastrado = clienteDAO.Adicionar(cliente);
            return Ok(clienteCadastrado);

        }     
    }
}
