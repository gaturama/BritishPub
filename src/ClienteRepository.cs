using System.Collections.Generic;

namespace PubApp
{
    public class ClienteRepository : IClienteRepository
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int proximoId = 1;

        public void AdicionarCliente(Cliente cliente)
        {
            cliente.ClienteId = proximoId;
            clientes.Add(cliente);
            proximoId++;
        }

        public void ExcluirCliente(int clienteId)
        {
            Cliente cliente = clientes.Find(c => c.ClienteId == clienteId);
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }

        public List<Cliente> ObterClientes()
        {
            return clientes;
        }
    }
}
