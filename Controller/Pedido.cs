namespace Controller
{
    public interface IPedidoInputPort
    {
        void CadastrarPedido(string pedidoId, string descricao, string cliente);
        void AlterarPedido(string pedidoId, string descricao, string cliente);
        void ExcluirPedido(string pedidoId);
        Model.Pedido BuscarPedido(string pedidoId);
        List<Model.Produto> ListarPedidos();
    }

    public class PedidoController : IPedidoInputPort
    {
        private readonly Model.IPedidoRepository _pedidoRepository
        private readonly IPedidoOutputPort _pedidoOutputPort;

        public PedidoController(IPedidoOutputPort pedidoOutputPort, IPedidoRepository PedidoRepository)
        {
            _pedidoRepository = PedidoRepository;
            _pedidoOutputPort = pedidoOutputPort;
        }

        public void CadastrarPedido(string pedidoId, string descricao, string cliente)
        {
            try
            {
                int idConvert = int.Parse(pedidoId);
                Model.Pedido pedido = new Model.Pedido(idConvert, descricao, cliente);
                _pedidoRepository.SalvarPedido(pedido);
                _pedidoOutputPort.PedidoCadastradoComSucesso();
            }
            catch (Exception e)
            {
                _pedidoOutputPort.ErroAoCadastrarPedido(e.Message);
            }
        }

        public void AlterarPedido(string pedidoId, string descricao, string cliente)
        {
            try
            {
                int idConvert = int.Parse(pedidoId);
                Model.Pedido pedido = _pedidoRepository.BuscarPedido(idConvert);
                if(pedido == null)
                {
                    throw new Exception("Pedido não encontrado");
                }
                Produto.AlterarPedido(pedidoId, descricao, cliente);
                _pedidoRepository.SalvarPedido(pedido);
                _pedidoOutputPort.PedidoAlteradoComSucesso();
            }
            catch (Exception e)
            {
                _pedidoOutputPort.ErroAoAlterarPedido(e.Message);
            }
        }

        public void ExcluirPedido(string pedidoId)
        {
            try
            {
                int idConvert = int.Parse(pedidoId);
                Model.Pedido pedido = _pedidoRepository.BuscarPedido(idConvert);
                if(pedido == null)
                {
                    throw new Exception("Pedido não encontrado")
                }
                _pedidoRepository.ExcluirPedido(idConvert);
                _pedidoOutputPort.PedidoExcluidoComSucesso();
            }
            catch (Exception e)
            {
                _pedidoOutputPort.ErroAoExcluirPedido(e.Message);
            }
        }

        public Model.Pedido BuscarPedido(string pedidoId)
        {
            try
            {
                int idConvert = int.Parse(pedidoId);
                return _pedidoRepository.BuscarProduto(idConvert);
            }
            catch (Exception e)
            {
                throw new Exception("Id inválido: " + e.Message);
            }
        }


        public List<Model.Pedido> ListarPedidos()
        {
            return _pedidoRepository.ListarPedidos();
        }
    }
}