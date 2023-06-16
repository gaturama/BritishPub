using System.Collections.Generic;

namespace PubApp
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
        void ExcluirCliente(int clienteId);
        List<Cliente> ObterClientes();
    }
}
