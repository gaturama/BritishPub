using System.Collections.Generic;
using Models;

namespace Interface
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
        void ExcluirCliente(int clienteId);
        List<Cliente> ObterClientes();
    }
}
