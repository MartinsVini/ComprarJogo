using ComprarJogo.Data;
using ComprarJogo.Models;
using ComprarJogo.Repository;
using ComprarJogo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComprarJogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DAO<Cliente> clienteDAO;
        private readonly CompraDbContext dbContext;

        public ClienteController(DAO<Cliente> clienteDAO, CompraDbContext dbContext)
        {
            this.clienteDAO = clienteDAO;
            this.dbContext = dbContext;
        }

        [HttpGet("/BuscarTodosClientes")]
        public  ActionResult<List<Cliente>> BuscarTodos()
        {
            List<Cliente> clientes = clienteDAO.BuscarTodos();
            return Ok(clientes);
        }

        [HttpGet("/Logar")]
        public ActionResult<Cliente> Logar(string email, string senha, CompraDbContext dbContext)
        {
            bool logado =  clienteDAO.Logar(email, senha, dbContext);
            return Ok(logado);
        }


        [HttpGet("/BuscarPorEmail")]
        public ActionResult<List<Cliente>> BuscarPorEmail(string email, CompraDbContext dbContext)
        {
            Cliente cliente =  clienteDAO.BuscarPorEmail(email, dbContext);
            return Ok(cliente);
        }

        [HttpPost("/AdicionarCliente")]
        public ActionResult<Cliente> AdicionarCliente([FromBody] Cliente cliente)
        {
            Cliente clienteCadastrado = clienteDAO.Adicionar(cliente);
            return Ok(clienteCadastrado);

        }

        [HttpPut("/AtualizarCliente")]
        public ActionResult<Cliente> Atualizar([FromBody] Cliente cliente, int id)
        {
            cliente.IdCliente = id;
            Cliente clienteAtualizado = clienteDAO.Atualizar(cliente, id);
            return Ok(clienteAtualizado);

        }

        [HttpDelete("/ApagarCliente")]
        public ActionResult<Cliente> Apagar( int id)
        {

            bool apagado = clienteDAO.Apagar(id);
            return Ok(apagado);




        }

        
    }
}
