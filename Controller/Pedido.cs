namespace Controller
{
    public class Pedido
    {
        public static void CadastrarPedido(string PedidoId, string Descricao, string Cliente)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(PedidoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Pedido pedido = new Model.Pedido(idConvert, Descricao, Cliente);
        }

        public static void AlterarPedido(string PedidoId, string Descricao, string Cliente)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(PedidoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Pedido.AlterarPedido(idConvert, Descricao, Cliente);
        }

        public static void ExcluirPedido(string PedidoId)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(PedidoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            Model.Pedido.ExcluirPedido(idConvert);
        }

        public static Model.Pedido BuscarPedido(string PedidoId)
        {
            int idConvert = 0;
            try{
                idConvert = int.Parse(PedidoId);
            }catch(Exception){
                throw new Exception("Id inválido");
            }
            return Model.Pedido.BuscarPedido(idConvert);
        }

        public static List<Model.Pedido> ListarPedidos()
        {
            return Model.Pedido.Pedidos;
        }
    }
}