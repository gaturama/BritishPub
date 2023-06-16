using System.Collections.Generic;

namespace PubApp
{
    public class ClienteService
    {
        private IClienteRepository clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public void CadastrarCliente(string nome, int telefone)
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
