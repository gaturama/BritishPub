using Models;

namespace Controllers
{
    public class ClienteController 
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int clienteId = 1;

        public void Adicionar(string nome, int telefone)
        {
            Cliente cliente = new Cliente
            {
                ClienteId = clienteId,
                Nome = nome,
                Telefone = telefone
            };
            clientes.Add(cliente);
            clienteId++;
        }

        public List<Cliente> ObterClientes()
        {
            return clientes;
        }
    }
}