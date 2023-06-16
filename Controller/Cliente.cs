using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class ClienteController
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int clienteId = 1;

        public void CadastrarCliente(string nome, int telefone)
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

        public void ExcluirCliente(int clienteId)
        {
            Cliente cliente = clientes.Find(c => c.ClienteId == clienteId);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        public List<Cliente> ObterClientes()
        {
            return clientes;
        }
    }
}
