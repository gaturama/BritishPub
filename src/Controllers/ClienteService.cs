using Models;
using Interface;

namespace Controllers
{
    public class ClienteService
    {
        private IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public void CadastrarCliente(string nome, string telefone)
        {
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Telefone = telefone
            };
            clienteRepository.AdicionarCliente(cliente);
        }

        public void ExcluirCliente(int clienteId)
        {
            clienteRepository.ExcluirCliente(clienteId);
        }

        public List<Cliente> ObterClientes()
        {
            return clienteRepository.ObterClientes();
        }
    }
}
